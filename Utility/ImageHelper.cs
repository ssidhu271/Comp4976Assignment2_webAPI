using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Processing;

namespace ExoticCarsAPI.Utility;

public static class ImageHelper
{
    public static string ConvertImageToBase64(string imagePath)
    {
        using (var image = Image.Load(imagePath))
        {
            // Resize image if width exceeds 300 pixels
            if (image.Width > 300)
            {
                image.Mutate(x => x.Resize(300, 0)); // Maintain aspect ratio with height 0
            }

            using (var ms = new MemoryStream())
            {
                // Save as PNG to preserve original format and transparency if needed
                image.Save(ms, new PngEncoder());
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }
    }
}
