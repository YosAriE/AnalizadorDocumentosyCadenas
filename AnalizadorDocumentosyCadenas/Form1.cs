using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows.Forms;

namespace AnalizadorDocumentosyCadenas
{
    public partial class Form1 : Form
    {
        bool ban = true;
        List<char> _numeros = new List<char>(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
        List<char> _operadores = new List<char>(new char[] { '+', '-', '*', '/', '^' });
        List<char> _delimitadores = new List<char>(new char[] { '(', ')', '[', ']', '{', '}' });
        List<string> _palabras = new List<string>() { "IF", "WHILE", "RETURN", "CONTINUE", "BREAK", "DO" };
        List<char> _variables = new List<char>(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' });

        DataTable _tblResultados = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtExpresion.Clear();
            txtContenido.Clear();
            textRuta.Clear();
            _tblResultados.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _tblResultados.Clear();
            List<char> _elementos;
            if (!ban)
            {
                _elementos = txtContenido.Text.Replace(" ", "").ToCharArray().ToList();
                ban = true;
            }
            else
                _elementos = txtExpresion.Text.Replace(" ", "").ToCharArray().ToList();
            if (_elementos.Count > 0)

            {
                DataRow _fila;
                foreach (char elemento in _elementos)
                {
                    _fila = _tblResultados.NewRow();

                    if (_numeros.Contains(elemento))
                    {
                        _fila["Token"] = elemento;
                        _fila["Tipo"] = "Número";
                    }
                    else if (_operadores.Contains(elemento))
                    {
                        _fila["Token"] = elemento;
                        _fila["Tipo"] = "Operadores";
                    }
                    else if (_delimitadores.Contains(elemento))
                    {
                        _fila["Token"] = elemento;
                        _fila["Tipo"] = "Delimitadores";
                    }
                    else if (_variables.Contains(elemento))
                    {
                        _fila["Token"] = elemento;
                        _fila["Tipo"] = "Variables";
                    }
                    else
                    {
                        bool esPalabraReservada = false;
                        foreach (string palabraReservada in _palabras)
                        {
                            if (txtContenido.Text.StartsWith(palabraReservada))
                            {
                                _fila["Token"] = palabraReservada;
                                _fila["Tipo"] = "Palabra Reservada";
                                esPalabraReservada = true;
                                break;
                            }
                        }

                        if (!esPalabraReservada)
                        {
                            _fila["Token"] = elemento;
                            _fila["Tipo"] = "Error";
                        }
                    }

                    _tblResultados.Rows.Add(_fila);
                }

                dataGridView1.DataSource = _tblResultados;
                dataGridView1.Refresh();
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _tblResultados.Columns.Add("Token", typeof(string));
            _tblResultados.Columns.Add("Tipo", typeof(string));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                ban = false;
                openFileDialog1.Filter = "Archivo de Texto (*.txt)| *.txt";
                openFileDialog1.FileName = "Seleccione un Archivo";
                openFileDialog1.InitialDirectory = "C:/";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.textRuta.Text = openFileDialog1.FileName;
                }
                System.IO.StreamReader sr = new System.IO.StreamReader(textRuta.Text, Encoding.Default);
                string texto;
                texto = sr.ReadToEnd();
                sr.Close();
                txtContenido.Text = texto;

            }

        }
    }
}
