
namespace MFC
{
    class Export
    {
        public void Excel_Generation(string fio, string kod, string s, string po, string coldPr, string coldTek, string hotPr, string hotTek, decimal cena)
        {
            Abonent_Otdel AO = new Abonent_Otdel();
            Microsoft.Office.Interop.Excel.Application TNSE_App = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook WB_TNS = TNSE_App.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet WS_TNS = (Microsoft.Office.Interop.Excel.Worksheet)WB_TNS.ActiveSheet;
            WS_TNS.Cells[1, 1] = "ЕПД" + "\n" + "Единый платежный документ";
            WS_TNS.Name = "ЕПД";
            WS_TNS.Cells[2, 1] = "Плательщик";
            WS_TNS.Cells[2, 2] = fio;
            WS_TNS.Cells[3, 1] = "Код плательщика";
            WS_TNS.Cells[3, 2] = kod;
            WS_TNS.Cells[4, 1] = "Период с-по";
            WS_TNS.Cells[4, 2] = s;
            WS_TNS.Cells[4, 3] = po;
            WS_TNS.Cells[5, 1] = "Показания";
            WS_TNS.Cells[5, 2] = "Предыдущие";
            WS_TNS.Cells[5, 3] = "Текущие";
            WS_TNS.Cells[6, 1] = "Холодное";
            WS_TNS.Cells[6, 2] = coldPr;
            WS_TNS.Cells[6, 3] = coldTek;
            WS_TNS.Cells[7, 1] = "Горячее";
            WS_TNS.Cells[7, 2] = hotPr;
            WS_TNS.Cells[7, 3] = hotTek;
            WS_TNS.Cells[8, 1] = "Сумма оплаты";
            WS_TNS.Cells[8, 2] = cena;
            WS_TNS.Range[WS_TNS.Cells[3, 2], WS_TNS.Cells[3, 3]].Merge();
            WS_TNS.Range[WS_TNS.Cells[2, 2], WS_TNS.Cells[2, 3]].Merge();
            Microsoft.Office.Interop.Excel.Range Doc_Range = WS_TNS.UsedRange;
            Microsoft.Office.Interop.Excel.Range c1_Range = Doc_Range.Cells[1, 3];
            Microsoft.Office.Interop.Excel.Range c2_Range = Doc_Range.Cells[2, 1];
            Microsoft.Office.Interop.Excel.Range c3_Range = Doc_Range.Cells[1, 2];
            Microsoft.Office.Interop.Excel.Range c3_1_Range = Doc_Range.Cells[1, 1];
            Microsoft.Office.Interop.Excel.Range c4_Range = Doc_Range.Cells[3, 1];
            Microsoft.Office.Interop.Excel.Range c5_Range = Doc_Range.Cells[4, 1];
            Microsoft.Office.Interop.Excel.Range c6_Range = Doc_Range.Cells[5, 1];
            Microsoft.Office.Interop.Excel.Range c7_Range = Doc_Range.Cells[5, 2];
            Microsoft.Office.Interop.Excel.Range c8_Range = Doc_Range.Cells[5, 3];
            Microsoft.Office.Interop.Excel.Range c9_Range = Doc_Range.Cells[6, 1];
            Microsoft.Office.Interop.Excel.Range c10_Range = Doc_Range.Cells[7, 1];
            Microsoft.Office.Interop.Excel.Range c11_Range = Doc_Range.Cells[8, 1];
            c1_Range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            c1_Range.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            c2_Range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            c2_Range.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            c3_Range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            c3_Range.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            c3_1_Range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            c3_1_Range.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            c4_Range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            c4_Range.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            c5_Range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            c5_Range.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            Microsoft.Office.Interop.Excel.Borders C_1_Border = c1_Range.Borders;
            C_1_Border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            C_1_Border.Weight = 3d;
            Microsoft.Office.Interop.Excel.Borders C_2_Border = c2_Range.Borders;
            C_2_Border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            C_2_Border.Weight = 3d;
            Microsoft.Office.Interop.Excel.Borders C_3_Border = c3_Range.Borders;
            C_3_Border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            C_3_Border.Weight = 3d;
            Microsoft.Office.Interop.Excel.Borders C_3_1_Border = c3_1_Range.Borders;
            C_3_1_Border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            C_3_1_Border.Weight = 3d;
            Microsoft.Office.Interop.Excel.Borders C_4_Border = c4_Range.Borders;
            C_4_Border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            C_4_Border.Weight = 3d;
            Microsoft.Office.Interop.Excel.Borders C_5_Border = c5_Range.Borders;
            C_5_Border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            C_5_Border.Weight = 3d;
            Microsoft.Office.Interop.Excel.Borders C_6_Border = c6_Range.Borders;
            C_6_Border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            C_6_Border.Weight = 3d;
            Microsoft.Office.Interop.Excel.Borders C_7_Border = c7_Range.Borders;
            C_7_Border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            C_7_Border.Weight = 3d;
            Microsoft.Office.Interop.Excel.Borders C_8_Border = c8_Range.Borders;
            C_8_Border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            C_8_Border.Weight = 3d;
            Microsoft.Office.Interop.Excel.Borders C_9_Border = c9_Range.Borders;
            C_9_Border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            C_9_Border.Weight = 3d;
            Microsoft.Office.Interop.Excel.Borders C_10_Border = c10_Range.Borders;
            C_10_Border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            C_10_Border.Weight = 3d;
            Microsoft.Office.Interop.Excel.Borders C_11_Border = c11_Range.Borders;
            C_11_Border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            C_11_Border.Weight = 3d;
            WS_TNS.Range[WS_TNS.Cells[1, 1], WS_TNS.Cells[1, 3]].Merge();
            WS_TNS.Columns.AutoFit();
            TNSE_App.Visible = true;
            //WB_TNS.Save();
            //WB_TNS.Close();
            TNSE_App.Quit();
        }
    }
}
