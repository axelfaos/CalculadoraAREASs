using System.Diagnostics;

namespace CalculadoraAREAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void triangulo_Click(object sender, EventArgs e)
        {
            // Solicitar base y altura
            double baseTriangulo = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduce la base del tri�ngulo:", "Base del tri�ngulo"));
            double alturaTriangulo = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduce la altura del tri�ngulo:", "Altura del tri�ngulo"));

            // Calcular �rea
            double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

            // Mostrar resultado
            MessageBox.Show($"El �rea del tri�ngulo es: {areaTriangulo}", "Resultado");
        }

        private void circulo_Click(object sender, EventArgs e)
        {
            // Solicitar radio
            double radio = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduce el radio del c�rculo:", "Radio del c�rculo"));

            // Calcular �rea
            double areaCirculo = Math.PI * Math.Pow(radio, 2);

            // Mostrar resultado
            MessageBox.Show($"El �rea del c�rculo es: {areaCirculo}", "Resultado");
        }

        private void cuadrado_Click(object sender, EventArgs e)
        {
            // Solicitar lado
            double lado = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduce el lado del cuadrado:", "Lado del cuadrado"));

            // Calcular �rea
            double areaCuadrado = Math.Pow(lado, 2);

            // Mostrar resultado
            MessageBox.Show($"El �rea del cuadrado es: {areaCuadrado}", "Resultado");
        }

        private void rectangulo_Click(object sender, EventArgs e)
        {
            // Solicitar base y altura
            double baseRectangulo = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduce la base del rect�ngulo:", "Base del rect�ngulo"));
            double alturaRectangulo = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduce la altura del rect�ngulo:", "Altura del rect�ngulo"));

            // Calcular �rea
            double areaRectangulo = baseRectangulo * alturaRectangulo;

            // Mostrar resultado
            MessageBox.Show($"El �rea del rect�ngulo es: {areaRectangulo}", "Resultado");
        }

        private void trapecio_Click(object sender, EventArgs e)
        {
            // Solicitar bases y altura
            double baseMayor = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduce la base mayor del trapecio:", "Base mayor del trapecio"));
            double baseMenor = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduce la base menor del trapecio:", "Base menor del trapecio"));
            double alturaTrapecio = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduce la altura del trapecio:", "Altura del trapecio"));

            // Calcular �rea
            double areaTrapecio = ((baseMayor + baseMenor) * alturaTrapecio) / 2;

            // Mostrar resultado
            MessageBox.Show($"El �rea del trapecio es: {areaTrapecio}", "Resultado");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento vac�o
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta del directorio donde est� el repositorio
                string repoPath = @"C:\Users\axelf\Documents\Visual Studio 2022\Projects\CalculadoraAREAS";

                // 1. Ejecutar "git add ."
                EjecutarComandoGit("git add .", repoPath);

                // 2. Ejecutar "git commit -m 'Actualizaci�n desde la aplicaci�n'"
                EjecutarComandoGit("git commit -m \"Actualizaci�n desde la aplicaci�n\"", repoPath);

                // 3. Ejecutar "git push origin master"
                EjecutarComandoGit("git push origin master", repoPath);

                MessageBox.Show("Repositorio actualizado con �xito en GitHub.", "�xito");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el repositorio: {ex.Message}", "Error");
            }
        }

        private void EjecutarComandoGit(string comando, string directorioTrabajo)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c " + comando);
            processInfo.WorkingDirectory = directorioTrabajo;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.UseShellExecute = false;
            processInfo.CreateNoWindow = true;

            using (Process process = new Process())
            {
                process.StartInfo = processInfo;
                process.Start();

                string resultado = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                if (!string.IsNullOrEmpty(error))
                {
                    throw new Exception($"Error en Git: {error}");
                }
            }
        }
    }
}
