using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mngrs
{
    public class UtilitiesMngr
    {
        /// <summary>
        /// Pega campos tipo textBox, comboBox, masckedBox dentro de um object[] e checa se nenhum esta vazio e retorna False, porque não tem nenhum campo vazio
        /// </summary>
        /// <param name="fields"></param>
        /// <returns></returns>
        public static bool isFieldsEmpty(object[] fields)
        {
            TextBox[] txts = new TextBox[fields.Length - 1];
            for (int i = 0; i < fields.Length - 1; i++)
            {
                txts[i] = (fields[i] as TextBox);
            }

            foreach (TextBox txt in txts)
            {
                if (txt.Text != "")
                {
                    return true;
                }
            }

            return false;
        }

        public static List<string> convertToListString(string[] strArray)
        {
            List<string> lst = new List<string>();

            foreach (string item in strArray)
            {
                lst.Add(item);
            }

            return lst;
        }
        
        public static void Load_Recent(ref ToolStripMenuItem tsmi, EventHandler tsmi_Click, string MessageForNoItems)
        {
            string[] recents = GetFromRecent();
            List<ToolStripItem> itens = new List<ToolStripItem>();
            for (int i = 0; i < recents.Length; i++)
            {
                try
                {
                    itens.Add(new ToolStripMenuItem(recents[i].Split('=')[0], null, tsmi_Click, recents[i].Split('=')[1]));
                }
                catch (IndexOutOfRangeException)
                {
                    break;
                }
                catch (ArgumentOutOfRangeException)
                {
                    break;
                }
            }
            tsmi.DropDownItems.Clear();
            if (itens.Count > 0)
            {
                ToolStripItem[] itensMenu = new ToolStripItem[itens.Count];
                for (int i = 0; i < itensMenu.Length; i++)
                {
                    itensMenu[i] = itens[i];
                }
                tsmi.DropDownItems.AddRange(itensMenu);
            }
            else
            {
                tsmi.DropDownItems.Add(new ToolStripMenuItem(MessageForNoItems));
            }
        }

        public static string[] GetFromRecent()
        {
            string[] retorno = new string[8]
            {
                "","","","","","","",""
            };
            List<DataTable> tables = new List<DataTable>()
            {
                ConfigMngr.DatatableModel("RecentFiles")
            };
            ConfigMngr config = new ConfigMngr("Data", "dat", tables);
            List<string> lst = new List<string>();
            config.TableToList(config.Configs[0], out lst);

            //lst.RemoveAt(0);
            lst.Reverse();
            for (int i = 0; i < retorno.Length && i < lst.Count; i++)
            {
                retorno[i] = lst[i];
            }
            return retorno;
        }

        public static void AddToRecent(string fileName, string filePath)
        {
            List<DataTable> tables = new List<DataTable>()
            {
                ConfigMngr.DatatableModel("RecentFiles")
            };
            ConfigMngr config = new ConfigMngr("Data", "dat", tables);

            for (int i = 0; i < config.Configs[0].Rows.Count; i++)
            {
                if (config.Configs[0].Rows[i][0].ToString() == fileName)
                {
                    config.Configs[0].Rows.RemoveAt(i);
                    break;
                }
            }
            config.Configs[0].Rows.Add(fileName, filePath);

            if (config.Configs[0].Rows.Count > 8)
                config.Configs[0].Rows.RemoveAt(0);

            config.writeOnFile();
        }
    }
}
