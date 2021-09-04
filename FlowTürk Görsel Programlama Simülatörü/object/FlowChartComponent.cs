using FlowTürk_Görsel_Programlama_Simülatörü.objects.components;
using FlowTürk_Görsel_Programlama_Simülatörü.objects.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowTürk_Görsel_Programlama_Simülatörü.objects
{
    public  abstract class FlowChartComponent :Component
    {

        public String refName;

        public Point point { get; set; }

        public Component dependComponents;

        public LineComponent dependLineComponents;




        public abstract void InitializeComponent();


        public abstract void Dispose();
       
    }
}
