using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio_Practica2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                Lista.Items.Add(new ListItem("Iphone 12", "1"));
                Lista.Items.Add(new ListItem("Airpods Pro", "2"));
                Lista.Items.Add(new ListItem("Lenovo Legion i5", "3"));
                Lista.Items.Add(new ListItem("Ipad Pro", "4"));
                Lista.Items.Add(new ListItem("Mouse G203", "5"));
                Lista.Items.Add(new ListItem("Teclado GPro", "6"));
                Lista.Items.Add(new ListItem("Audifonos G432", "7"));

            }

        }
        protected void boton_ServerClick(Object sender, EventArgs e)
        {
            ListItem elemento = Lista.Items[Lista.SelectedIndex];
            if (elemento.Value == "1")
            {
                Descripcion.InnerText = "l nuevo Apple 12 llega con llega con muchas de las características de sus hermanos mayores y a un precio cómodo. Con tecnología OLED y resolución Full HD (Super retina XDR) para brindarte la mejor experiencia en imagen, llega con el nuevo tipo de conexión 5G, su capacidad y potencia cada vez es mejor y lo puedes encontrar en diversos colores ¡Desliza, haz clic en el que te gusta y conoce mucho mas acerca de su funcionamiento!";
                Precio.InnerText = "Precio: S/.4500  Incluye igv";
                Grafico.Src = "iphone12.jpg";
                Grafico.Alt = "Modelo solicitado";
                Grafico.Visible = true;
            }
            if (elemento.Value == "2")
            {
                Descripcion.InnerText = "Has vibrar tus oídos y tus emociones con los sonidos que más te gusten, en iShop encuentras los dispositivos de audio que necesitas para tus actividades de hogar, oficina y al aire libre. Conoce nuestras marcas asociadas, haz clic en el producto que mas te llame la atención, conoce sus características, precio y llévalo contigo.";
                Precio.InnerText = "Precio: S/.540  Incluye igv";
                Grafico.Src = "airpodsPro.jpg";
                Grafico.Alt = "Modelo solicitado";
                Grafico.Visible = true;
            }
            if (elemento.Value == "3")
            {
                Descripcion.InnerText = "La Legion 5i Torre es todo rendimiento gracias a los procesadores hasta Intel® Core™ i9 de 10ma generación (no incluidos en todos los modelos) que te permiten disfrutar de una experiencia de gaming definitiva. Lleva tu sistema a lo más alto de la clasificación con hasta 10 núcleos, 20 subprocesos y Turbo Boost de hasta 5.3 GHz. También puedes jugar, transmitir en streaming y grabar a máxima velocidad gracias a la conexión Intel® WiFi 6 opcional, lo último para jugar sin interrupciones.";
                Precio.InnerText = "Precio: S/.5530  Incluye igv";
                Grafico.Src = "LenovoLegion.jpg";
                Grafico.Alt = "Modelo solicitado";
                Grafico.Visible = true;
            }
            if (elemento.Value == "4")
            {
                Descripcion.InnerText = "El iPad Pro con pantalla de 12.9 pulgadas para el 2020 que llega con un procesador Apple A12Z Bionic y una cámara triple de 12 MP, 10 MP y scanner LiDAR TOF 3D. Con opciones de almacenamiento de 128GB, 256GB, 512GB y 1TB, el iPad Pro 12.9 (2020) cuenta con cuatro parlantes stereo, cámara frontal de 7 megapixels con Face ID, soporte para el Apple Pen con integración Bluetooth y soporte magnético, batería de 9720 mAh, y opciones de solo Wi-Fi o Wi-Fi + LTE, corriendo el iPadOS 14, el sistema operativo de Apple exclusivo para sus tablets.";
                Precio.InnerText = "Precio: S/.4750  Incluye igv";

                Grafico.Src = "ipadPro.jpg";
                Grafico.Alt = "Modelo solicitado";
                Grafico.Visible = true;
            }
            if (elemento.Value == "5")
            {
                Descripcion.InnerText = "Logitech G203 es un ratón gaming que pretende ofrecer una solución con una relación entre precio y prestaciones muy atractiva para ello se ha montado un sensor óptico de gran precisión.También se ha optado por un diseño ergonómico y basado en materiales de la mejor calidad.";
                Precio.InnerText = "Precio: S/.105  Incluye igv";
                Grafico.Src = "g203.jpg";
                Grafico.Alt = "Modelo solicitado";
                Grafico.Visible = true;
            }
            if (elemento.Value == "6")
            {
                Descripcion.InnerText = "Los responsables de Logitech llevan tiempo ofreciendo soluciones dirigidas al mundo del gaming, y ahora han presentado una nueva propuesta en el sector de los teclados: se trata del Logitech G Pro Mechanical Keyboard, un teclado mecánico singular.Lo es por un par de razones.La primera, su configuración 'tenkeyless' que hace que se prescinda del teclado numérico para contar con un periférico más compacto.La segunda, sus interruptores de alta velocidad, que están orientados a que tengas una ligera ventaja en juegos online y te muevas antes y más rápido que tus competidores";
                Precio.InnerText = "Precio: S/.440  Incluye igv";
                Grafico.Src = "gpro.jpg";
                Grafico.Alt = "Modelo solicitado";
                Grafico.Visible = true;
            }
            if (elemento.Value == "7")
            {
                Descripcion.InnerText = "Con los audífonos G432, estarás rodeado por el entorno del juego. Siente la emoción de estar totalmente inmerso en la acción y de que siempre te oigan para una experiencia de juego completa..Los grandes transductores de audio de 50 mm producen un sonido completamente expansivo para una experiencia de juego más inmersiva. Por fin tus juegos favoritos sonarán como se concibieron: asombrosamente.";
                Precio.InnerText = "Precio: S/.235  Incluye igv";
                Grafico.Src = "g432.jpg";
                Grafico.Alt = "Modelo solicitado";
                Grafico.Visible = true;
            }


        }
    }
}
