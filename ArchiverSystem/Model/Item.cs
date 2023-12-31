﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ArchiverSystem.Model
{
    public class Item
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Qty { get; set; }
        public DateTime InputDate { get; set; }
        public DateTime UpdateDate { get; set;}
        [JsonIgnore]
        public byte[] Image {get; set;}
        public string ImageB64 { get; set;}

        public Item() 
        {
            
        }

        public void UpdateItem()
        {
            UpdateDate = DateTime.Now;
        }
    }
}
