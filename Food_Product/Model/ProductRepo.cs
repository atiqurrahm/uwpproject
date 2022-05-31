using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Product.Model
{
    public class ProductRepo
    {
        ObservableCollection<Product> products;
        public ProductRepo()
        {
            this.products = new ObservableCollection<Product>()
            {
                new Product{ Id= 1, Name="Chachi Chinigura Chal",Weight="5kg", Price=200, Manufacture=new DateTime(2022, 3, 12),Expiare=new DateTime(2023,3,12), CompanyName="Square Group Ltd", Category="Food",BatchId=22665845, Picture="Assets/chashi.jpg" },
                new Product{ Id= 2, Name="Radhuni Halim Mix",Weight="200gm", Price=250, Manufacture=new DateTime(2022, 3, 11),Expiare=new DateTime(2023,3,12), CompanyName="Square Group Ltd", Category="Food",BatchId=22665845, Picture="Assets/halimMix.jpg" },
                new Product{ Id= 3, Name="Ruchi Orange Jam",Weight="200gm", Price=500, Manufacture=new DateTime(2022, 3, 12),Expiare=new DateTime(2023,3,12), CompanyName="Square Group Ltd", Category="Food",BatchId=22665845, Picture="Assets/Orange-Jam.jpg" },
                new Product{ Id= 4, Name="Ruchi PremiumMix Chanachur",Weight="200gm", Price=400, Manufacture=new DateTime(2022, 3, 12),Expiare=new DateTime(2023,3,12), CompanyName="Square Group Ltd", Category="Food",BatchId=22665845,  Picture="Assets/Premiummix.jpg" },
                new Product{ Id= 5, Name="Cat Food",Weight="500gm", Price=900, Manufacture=new DateTime(2022, 3, 12),Expiare=new DateTime(2023,3,12), CompanyName="Square Group Ltd", Category="Food",BatchId=22665845, Picture="Assets/Cat.jpg" },
                new Product{ Id= 6, Name="NESTLÉ NESCAFÉ CLASSIC COFFEE JAR ( 100 GM )",Weight="100gm", Price=310, Manufacture=new DateTime(2022, 3, 11),Expiare=new DateTime(2023,3,12), CompanyName="Nestle", Category="Food",BatchId=22665845,Picture="Assets/Coffee.jpg" },
                new Product{ Id= 7, Name="Diploma Full Cream Milk Powder",Weight="500gm", Price=250, Manufacture=new DateTime(2022, 3, 11),Expiare=new DateTime(2023,3,12), CompanyName="Desh Logistics Co. Ltd.", Category="Food",BatchId=22665845, Picture="Assets/Diploma.jpg" },
                new Product{ Id= 8, Name="Dragon Well Green Tea",Weight="100gm", Price=825.00, Manufacture=new DateTime(2022, 3, 11),Expiare=new DateTime(2023,3,12), CompanyName="Square Group Ltd", Category="Food",BatchId=22665845, Picture="Assets/Dragon.jpg" },
                new Product{ Id= 9, Name="HaisenPet Bentonite Cat Litter 5L Lemon",Weight="5 Ltr", Price=300.00, Manufacture=new DateTime(2022, 3, 11),Expiare=new DateTime(2023,3,12), CompanyName="Oatutter", Category="Cat Food",BatchId=22665845, Picture="Assets/haisenpet.jpg" },
                new Product{ Id= 10, Name="Quaker White Oats Tin",Weight="500g", Price=1500.00, Manufacture=new DateTime(2022, 3, 11),Expiare=new DateTime(2023,3,12), CompanyName="PepsiCo", Category="Food",BatchId=22665845, Picture="Assets/oats.jpg" },

            };
        }
        public ObservableCollection<Product> Get()
        {
            return this.products;
        }
        public Product Get(int id)
        {
            return this.products.FirstOrDefault(t => t.Id == id);
        }
    }
}
