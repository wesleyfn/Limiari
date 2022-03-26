using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limiari
{
    class Processing
    {
        public Processing()
        {
            
        }
        public void Quantization(Bitmap img, int quant)
        {
            var q = (int) Math.Pow(2,quant);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    var r = (byte) Math.Round(Convert.ToDouble((img.GetPixel(i, j).R / (255 / q)) * (255 / q)));
                    var g = (byte) Math.Round(Convert.ToDouble((img.GetPixel(i, j).G / (255 / q)) * (255 / q)));
                    var b = (byte) Math.Round(Convert.ToDouble((img.GetPixel(i, j).B / (255 / q)) * (255 / q)));

                    img.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
        }
        public void GrayScale(Bitmap img)
        {
            for(int i = 0; i < img.Width; i++) {
                for(int j = 0; j < img.Height; j++)
                {
                    double r = img.GetPixel(i, j).R * 0.3;
                    double g = img.GetPixel(i, j).G * 0.59;
                    double b = img.GetPixel(i, j).B * 0.11;
                    int cor = Convert.ToInt32(r + g + b);
                    img.SetPixel(i, j, Color.FromArgb(cor,cor,cor));
                }
            }
        }
        public void SobelEdge(Bitmap img)
        {
            int[,] kernel_gy = new int[,] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };
            int[,] kernel_gx = new int[,] { { 1, 0, -1 }, { 2, 0, -2 }, { 1, 0, -1 } };
            
            for (int i = 2; i < img.Width-2; i++) {
                for (int j = 2; j < img.Height-2; j++)
                {
                    float sumX = 0f;
                    float sumY = 0f;
                    for (int x = 0; x < 3; x++) {
                        for (int y = 0; y < 3; y++)
                        {
                            sumX += kernel_gx[y, x] * img.GetPixel(y + i, x + j).R;
                            sumY += kernel_gy[x, y] * img.GetPixel(x + i, y + j).R;
                        }
                    }
                    var cor = (int) Math.Sqrt(Math.Pow(sumX, 2) + Math.Pow(sumY, 2));
                    if (cor > 255) cor = 255;
                    img.SetPixel(i, j, Color.FromArgb(cor, cor, cor));
                    Graphics.FromImage(img);
                }
            }
        }
        public void RobertEdge(Bitmap img)
        {
            int[,] kernel_gy = new int[,] { { 1, 0 }, { 0, -1 } };
            int[,] kernel_gx = new int[,] { { 0, 1 }, { -1, 0 } };

            for (int i = 1; i < img.Width - 1; i++) {
                for (int j = 1; j < img.Height - 1; j++)
                {
                    float sumX = 0f;
                    float sumY = 0f;
                    for (int x = 0; x < 2; x++) {
                        for (int y = 0; y < 2; y++)
                        {
                            sumX += kernel_gx[y, x] * img.GetPixel(y + i, x + j).R;
                            sumY += kernel_gy[x, y] * img.GetPixel(x + i, y + j).R;
                        }
                    }
                    var cor = (byte)Math.Sqrt(Math.Pow(sumX, 2) + Math.Pow(sumY, 2));
                    if (cor > 255) cor = 255;
                    img.SetPixel(i, j, Color.FromArgb(cor, cor, cor));
                    Graphics.FromImage(img);
                }
            }
        }
        public void NegativeScale(Bitmap img)
        {
            FormMain form = new FormMain();
            for (int i = 0; i < img.Width; i++) {
                for (int j = 0; j < img.Height; j++)
                {
                    Color cor = img.GetPixel(i, j);
                    var r = 255 - (cor.R);
                    var g = 255 - (cor.G);
                    var b = 255 - (cor.B);
                    img.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
        }

    }  
}
