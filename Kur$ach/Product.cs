using System;
using System.Drawing;
using Newtonsoft.Json;

namespace Kur_ach
{
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        [JsonIgnore]
        public Image Image { get; set; }

        public string ImageBase64 { get; set; }

        public string Author { get; set; }
        public DateTime DateAdded { get; set; }
        public string Note { get; set; }

        // при збереженні
        public void PrepareForSave()
        {
            if (Image != null)
            {
                using (var ms = new System.IO.MemoryStream())
                {
                    Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    ImageBase64 = Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        // при завантаженні
        public void LoadFromBase64()
        {
            if (!string.IsNullOrEmpty(ImageBase64))
            {
                byte[] bytes = Convert.FromBase64String(ImageBase64);
                using (var ms = new System.IO.MemoryStream(bytes))
                {
                    Image = Image.FromStream(ms);
                }
            }
        }
    }
}