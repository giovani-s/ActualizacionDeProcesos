using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Globalization;

namespace Actualizacion_de_Procesos
{

    public partial class Form1 : Form
    {
        private string rutaDelArchivoExcel;
        private int proceso = 1;
        private int lastWrittenRow;
        private Excel.Workbook workbook;
        private Excel.Worksheet worksheet;
        private Excel.Application excelApp;

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox8.Text = "Fecha de HOY: " + DateTime.Now.ToString("dd/MM/yyyy");
            beforeStateCount.Value = 2;
            SetupDataGridView();

        }
        private void SetupDataGridView()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Fecha de consulta";
            dataGridView1.Columns[1].Name = "Ubicacion";
            dataGridView1.Columns[2].Name = "Actuacion";
            dataGridView1.Columns[3].Name = "Anotacion";
            dataGridView1.Columns[4].Name = "Estado";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private double DateToOleb(int datePosition)
        {

            string date = dataGridView1.Rows[datePosition + 1 + Convert.ToUInt16(beforeStateCount.Value)].Cells[0].Value.ToString(); // Esta es la fecha que leíste del DataGridView
            DateTime dateFromDataGrid = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            return dateFromDataGrid.ToOADate();

        }
        private void btnSaveState_Click(object sender, EventArgs e)
        {
            if (workbook != null)
            {
                int dataGridRowCount = dataGridView1.Rows.Cast<DataGridViewRow>().Count(row => row.Visible) - (2 + Convert.ToUInt16(beforeStateCount.Value));//-2 porque evito el espacio vacio y el ultimo dato que se obtiene de la ultima vez 

                for (int i = 0; i < dataGridRowCount; i++)
                {

                    ((Excel.Range)worksheet.Cells[i + lastWrittenRow + 1, 2]).Value2 = DateToOleb(i);
                    ((Excel.Range)worksheet.Cells[i + lastWrittenRow + 1, 3]).Value2 = (dataGridView1.Rows[i + 1 + Convert.ToUInt16(beforeStateCount.Value)].Cells[1].Value ?? "").ToString();
                    ((Excel.Range)worksheet.Cells[i + lastWrittenRow + 1, 4]).Value2 = (dataGridView1.Rows[i + 1 + Convert.ToUInt16(beforeStateCount.Value)].Cells[2].Value ?? "").ToString();
                    ((Excel.Range)worksheet.Cells[i + lastWrittenRow + 1, 5]).Value2 = (dataGridView1.Rows[i + 1 + Convert.ToUInt16(beforeStateCount.Value)].Cells[3].Value ?? "").ToString();
                    ((Excel.Range)worksheet.Cells[i + lastWrittenRow + 1, 7]).Value2 = (dataGridView1.Rows[i + 1 + Convert.ToUInt16(beforeStateCount.Value)].Cells[4].Value ?? "").ToString();

                }

                workbook.Save();
                dataGridView1.Rows.Clear();
                loadAllDataFromProcess();
            }
        }

        private int getLastDataWritten(int startColumn)
        {

            lastWrittenRow = worksheet.Cells.Find("*", System.Reflection.Missing.Value,
                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                               Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious,
                                               false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;

            while (lastWrittenRow > 0 && worksheet.Cells[lastWrittenRow, startColumn].Value2 == null)
            {
                lastWrittenRow--;
            }

            return lastWrittenRow;
        }
        private void loadAllDataFromProcess()
        {

            currentProcess.Text = "Proceso: " + worksheet.Name;

            textBox1.Text = (((Excel.Range)worksheet.Cells[9, "C"]).Value2 ?? "").ToString();
            textBox2.Text = (((Excel.Range)worksheet.Cells[9, "G"]).Value2 ?? "").ToString();
            textBox3.Text = (((Excel.Range)worksheet.Cells[11, "B"]).Value2 ?? "").ToString();
            textBox4.Text = (((Excel.Range)worksheet.Cells[11, "D"]).Value2 ?? "").ToString();
            textBox5.Text = (((Excel.Range)worksheet.Cells[11, "E"]).Value2 ?? "").ToString();
            textBox6.Text = (((Excel.Range)worksheet.Cells[11, "G"]).Value2 ?? "").ToString();

            /*
                               startColumn                                 endColumn

             startRow   |      startCell        ||       ...       ||        ...          |
                        |         ...           ||       ...       ||        ...          |
             endRow     |         ...           ||       ...       ||      endCell        |

             */

            int startColumn = 2; // Columna B
            int endColumn = 7; // Columna G

            lastWrittenRow = getLastDataWritten(startColumn);

            int startRow = lastWrittenRow - Convert.ToUInt16(beforeStateCount.Value); // Fila 1
            int endRow = lastWrittenRow; // la misma fila que la ultima escrita

            Excel.Range startCell = worksheet.Cells[startRow, startColumn];
            Excel.Range endCell = worksheet.Cells[endRow, endColumn];

           
            Excel.Range range = worksheet.Range[startCell, endCell];

            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;
            string[,] temporalRangeData = new string[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {

                    if (range.Cells[i + 1, j + 1].Value2 != null)
                    {
                        temporalRangeData[i, j] = range.Cells[i + 1, j + 1].Value2.ToString();

                    }
                    else
                    {
                        temporalRangeData[i, j] = "";
                    }

                }

            }

            for (int i = 0; i < rowCount; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < colCount; j++)
                {
                    if (j == 0)
                    {
                        try
                        {
                            double fechaComoNumero = Double.Parse(temporalRangeData[i, j]); // Este es el número que leíste de Excel
                            DateTime fecha = DateTime.FromOADate(fechaComoNumero);

                            dataGridView1.Rows[i].Cells[j].Value = fecha.ToString("dd/MM/yyyy");
                        }
                        catch (Exception)
                        {

                           
                        }
                        
                    }
                    else if (j == 4)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = temporalRangeData[i, j + 1];
                        break;

                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[j].Value = temporalRangeData[i, j];
                    }

                }

            }

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void loadNewExcelWorkbook()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecciona un archivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaDelArchivoExcel = openFileDialog.FileName;

                excelApp = new Excel.Application();
                excelApp.Visible = false;

               
                workbook = excelApp.Workbooks.Open(rutaDelArchivoExcel);
                worksheet = (Excel.Worksheet)workbook.Worksheets[proceso];

                loadAllDataFromProcess();

            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            if (workbook != null)
            {
                dataGridView1.Rows.Clear();
                workbook.Close();
                excelApp.Quit();

            }
            else
            {
                loadNewExcelWorkbook();
            }

        }

        private void btnAddProcess_Click(object sender, EventArgs e)
        {
            if (workbook != null)
            {
                worksheet.Activate();
                
                Excel.Worksheet newWorksheet = (Excel.Worksheet)workbook.Worksheets.Add();//(Before: workbook.Sheets[workbook.Sheets.Count]);

                string newProcessName = "";
                InputBox("Creando nuevo proceso", "Ingrese un nombre para el nuevo proceso", ref newProcessName);

                newWorksheet.Name = newProcessName;

                workbook.Save();
                workbook.Close();

                proceso = 1;
                workbook = excelApp.Workbooks.Open(rutaDelArchivoExcel);
                worksheet = (Excel.Worksheet)workbook.Worksheets[proceso];

                ((Excel.Range)worksheet.Cells[9, "C"]).Value2 = "=\"" + textBox1.Text + "\"";
                ((Excel.Range)worksheet.Cells[9, "G"]).Value2 = textBox2.Text;
                ((Excel.Range)worksheet.Cells[11, "B"]).Value2 = textBox3.Text;
                ((Excel.Range)worksheet.Cells[11, "D"]).Value2 = textBox4.Text;
                ((Excel.Range)worksheet.Cells[11, "E"]).Value2 = textBox5.Text;
                ((Excel.Range)worksheet.Cells[11, "G"]).Value2 = textBox6.Text;

                ((Excel.Range)worksheet.Cells[15, "B"]).Value2 = "Fecha Consulta";
                ((Excel.Range)worksheet.Cells[15, "C"]).Value2 = "Ubicación";
                ((Excel.Range)worksheet.Cells[15, "D"]).Value2 = "Actuación";
                ((Excel.Range)worksheet.Cells[15, "E"]).Value2 = "Anotación";
                ((Excel.Range)worksheet.Cells[15, "G"]).Value2 = "Estado";

                
                workbook.Save();

                dataGridView1.Rows.Clear();
                loadAllDataFromProcess();

            }
        }
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            System.Windows.Forms.Button buttonOk = new System.Windows.Forms.Button();
            System.Windows.Forms.Button buttonCancel = new System.Windows.Forms.Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
        private void btnAddStatus_Click(object sender, EventArgs e)
        {
            if (workbook != null)
            {
                dataGridView1.ClearSelection();

                string[] newStateOfProcess = { DateTime.Now.ToString("dd/MM/yyyy"), "", "", "SIN NOVEDAD", "Estados electronicos - " + DateTime.Now.ToString("dd/MM/yyyy") };
                dataGridView1.Rows.Add(newStateOfProcess);
            }

        }

        private void siguienteProceso()
        {

            if (proceso < workbook.Sheets.Count) worksheet = (Excel.Worksheet)workbook.Worksheets[++proceso];

        }
        private void anteriorProceso()
        {

            if (proceso > 1) worksheet = (Excel.Worksheet)workbook.Worksheets[--proceso];


        }
        private void btnNextProcess_Click(object sender, EventArgs e)
        {
            if (workbook != null)
            {
                dataGridView1.Rows.Clear();
                siguienteProceso();
                loadAllDataFromProcess();
            }

        }

        private void btnPreviousProcess_Click(object sender, EventArgs e)
        {
            if (workbook != null)
            {
                dataGridView1.Rows.Clear();
                anteriorProceso();
                loadAllDataFromProcess();
            }

        }
        void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            if (workbook != null)
            {
                workbook.Save();
                workbook.Close();
                excelApp.Quit();
            }

        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            if (workbook != null)
            {
                ((Excel.Range)worksheet.Cells[9, "C"]).Value2 = textBox1.Text;
                ((Excel.Range)worksheet.Cells[9, "G"]).Value2 = textBox2.Text;
                ((Excel.Range)worksheet.Cells[11, "B"]).Value2 = textBox3.Text;
                ((Excel.Range)worksheet.Cells[11, "D"]).Value2 = textBox4.Text;
                ((Excel.Range)worksheet.Cells[11, "E"]).Value2 = textBox5.Text;
                ((Excel.Range)worksheet.Cells[11, "G"]).Value2 = textBox6.Text;

                workbook.Save();

            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            textBox.SelectAll();
            Clipboard.SetText(textBox.Text);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            textBox.SelectAll();
            Clipboard.SetText(textBox.Text);
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            textBox.SelectAll();
            Clipboard.SetText(textBox.Text);
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            textBox.SelectAll();
            Clipboard.SetText(textBox.Text);
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            textBox.SelectAll();
            Clipboard.SetText(textBox.Text);
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            textBox.SelectAll();
            Clipboard.SetText(textBox.Text);
        }

        private void btnDelCurrentProcess_Click(object sender, EventArgs e)
        {
            if (workbook != null)
            {
               
                worksheet.Delete();

                workbook.Save();
               
                dataGridView1.Rows.Clear();

                proceso = 1;
                workbook = excelApp.Workbooks.Open(rutaDelArchivoExcel);
                worksheet = (Excel.Worksheet)workbook.Worksheets[proceso];

                loadAllDataFromProcess();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            if (workbook != null)
            {
                loadAllDataFromProcess();
            }
        }
    }

}
