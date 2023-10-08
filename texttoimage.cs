using System;
using System.Drawing;
using System.Drawing.Imaging;

public class TextToImageConverter
{
    public void ConvertTextToImage(string text, string outputPath)
    {
        // Create a bitmap object with desired width and height
        int width = 500;
        int height = 200;
        Bitmap bitmap = new Bitmap(width, height);

        // Create a graphics object from the bitmap
        using (Graphics graphics = Graphics.FromImage(bitmap))
        {
            // Set the background color
            graphics.Clear(Color.White);

            // Set the font size and type
            int fontSize = 50;
            Font font = new Font("Arial", fontSize);

            // Set the text color
            Brush textBrush = new SolidBrush(Color.Black);

            // Calculate the text position
            SizeF textSize = graphics.MeasureString(text, font);
            float textX = (width - textSize.Width) / 2;
            float textY = (height - textSize.Height) / 2;

            // Draw the text on the bitmap
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            graphics.DrawString(text, font, textBrush, textX, textY);
        }

        // Save the bitmap as an image file
        bitmap.Save(outputPath, ImageFormat.Png);
        Console.WriteLine($"Image saved to {outputPath}");
    }
}

// Example usage
public class Programm
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Please Enter Text to want to Convert in Image:-");
        string text = Console.ReadLine();
        string outputPath = "output1.jpg";
        TextToImageConverter converter = new TextToImageConverter();
        converter.ConvertTextToImage(text, outputPath);
    }
}

 