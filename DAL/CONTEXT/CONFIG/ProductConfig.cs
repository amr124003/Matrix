using DAL.ENTITIES;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CONTEXT.CONFIG
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.Id);



            #region laptop 

            builder.HasData
             (
                new Product
                {
                    Id = 1,
                    Name = "Dell G15-5515 Laptop - AMD Ryzen™ 7-5800H - 8GB - 512GB SSD - NVIDIA® GeForce RTX™ 3050 4GB - 15,6\" FHD - Win11 - Phantom Grey"
                    ,
                    Image = "Dell.jpg"
                    ,
                    Price = 46999M

                    ,
                    Section = "Laptop"
                },

                 new Product
                 {
                     Id = 2,
                     Name = "Huawei Matebook D15 Laptop - Intel® Core™ i5-1135G7 - 8GB - 256GB SSD - Intel® Iris® Xe Graphics - 15.6\"FHD - Win11 - Mystic Silver"
                    ,
                     Image = "Huawei Matebook D15.png"
                    ,
                     Price = 27999M


                    ,
                     Section = "Laptop"
                 },

                  new Product
                  {
                      Id = 3,
                      Name = "Huawei Matebook D14 Laptop - Intel® Core™ i5-1135G7 - 8GB - 512GB SSD - Intel® Iris® Xe Graphics - 14\"FHD - Win11 - Mystic Silver\r\n"
                    ,
                      Image = "Huawei Matebook D14.png"
                    ,
                      Price = 27999M

                    ,
                      Section = "Laptop"
                  },

                   new Product
                   {
                       Id = 4,
                       Name = "Dell G15-5515 Laptop - AMD Ryzen™ 7-5800H - 8GB - 512GB SSD - NVIDIA® GeForce RTX™ 3050 4GB - 15,6\" FHD - Win11 - Phantom Grey"
                    ,
                       Image = "Dell.jpg"
                    ,
                       Price = 46999M

                    ,
                       Section = "Laptop"
                   },

                    new Product
                    {
                        Id = 5,
                        Name = "Lenovo ThinkPad E14 Laptop - Intel® Core™ i7-1255U - 8GB - 512GB SSD - NVIDIA® GeForce MX550 2GB - 14\" FHD - Black"
                    ,
                        Image = "Lenovo ThinkPad E14.jpg"
                    ,
                        Price = 63999M

                    ,
                        Section = "Laptop"
                    },

                     new Product
                     {
                         Id = 6,
                         Name = "Dell Inspiron 5511 G15-E0002 Laptop - Intel® Core™ i7-11800H - 16GB - 512GB SSD - NVIDIA® GeForce RTX™ 3050 4GB - 15.6\" FHD - Shadow Grey\r\n"
                    ,
                         Image = "Dell inspiron 5511 G15 E0002.jpg"
                    ,
                         Price = 50999M
                    ,


                         Section = "Laptop"
                     },

                      new Product
                      {
                          Id = 7,
                          Name = "Lenovo ThinkBook 15 G2 Laptop - Intel® Core™ i5-1135G7 - 8GB - 1TB - Intel Iris Xe UHD Graphics - 15.6\" FHD - Gray"
                    ,
                          Image = "Lenovo ThinkPad 15 G2.jpg"
                    ,
                          Price = 37999M

                    ,
                          Section = "Laptop"
                      },

                       new Product
                       {
                           Id = 8,
                           Name = "Lenovo IdeaPad Flex 5 14ALC05 Laptop - AMD Ryzen™ 5-5500U - 8GB - 512GB SSD - AMD Radeon™ Graphics - 14.0 FHD - Win11 - Graphite Grey"
                    ,
                           Image = "Lenovo IdeaPad Flex 5 14ALC05.jpg"
                    ,
                           Price = 31999M

                    ,
                           Section = "Laptop"
                       },

                        new Product
                        {
                            Id = 9,
                            Name = "Lenovo IdeaPad Gaming 3 Laptop - AMD Ryzen™ 5 5500H - 8GB - 512GB SSD - NVIDIA® GeForce® RTX 2050 4GB - 15.6\" FHD - Shadow Black"
                    ,
                            Image = "Lenovo IdeaPad Gaming 3 .jpg"
                    ,
                            Price = 42999M


                    ,
                            Section = "Laptop"
                        },

                         new Product
                         {
                             Id = 10,
                             Name = "ASUS Vivobook Go 15E1504GA-NJ003W Laptop - Intel® Core™ i3-N305 - 8GB - 256GB SSD - Intel® UHD Graphics - 15.6\" FHD - Win11 - Cool Silver"
                    ,
                             Image = "ASUS Vivobook Go 15E1504G4-Hj003W.png"
                    ,
                             Price = 20999M

                    ,
                             Section = "Laptop"
                         },
                            new Product
                            {
                                Id = 11,
                                Name = "Lenovo IdeaPad Flex 5 14IAU7 Laptop - Intel® Core™ i7-1255U - Intel® Iris Xe Graphics - 8GB - 512GB SSD - 14\" WUXGA - Win11 - Storm Grey\r\n"
                    ,
                                Image = "Lenovo4.png"
                    ,
                                Price = 39999M

                    ,
                                Section = "Laptop"
                            },

                            new Product
                            {
                                Id = 12,
                                Name = "HP Pavilion 14 Laptop - Intel® Core™ i5-1235U - 8GB - 512GB SSD - NVIDIA® GeForce® MX550 2GB - 14\" FHD - Win11 - Silver"
                    ,
                                Image = "HP.jpg"
                    ,
                                Price = 36999M

                    ,
                                Section = "Laptop"
                            },
                                 new Product
                                 {
                                     Id = 13,
                                     Name = "Lenovo ThinkBook 15 Laptop - Intel® Core™ i5-1235U - 8GB - 512GB SSD - Intel® Iris® Xe Graphics - 15\" FHD - Mineral Grey"
                    ,
                                     Image = "Lenovo5.png"
                    ,
                                     Price = 36999M

                    ,
                                     Section = "Laptop"
                                 },
                                 new Product
                                 {
                                     Id = 14,
                                     Name = "ASUS Vivobook 15 X1504VA-NJ005W Laptop - Intel® Core™ i5-1335U - 8GB - 512GB SSD - Intel® UHD Graphics - 15.6\" FHD - Win11 - Quiet Blue"
                    ,
                                     Image = "ASUS Vivobook Go 15X1504V4-Hj005W.png"
                    ,
                                     Price = 36999M

                    ,
                                     Section = "Laptop"
                                 },
                                 new Product
                                 {
                                     Id = 15,
                                     Name = "Acer Aspire 3 Laptop - Intel® Core™ i5-1135G7 - 8GB - 1TB - NVIDIA® GeForce® MX350 2GB - 15.6\"FHD - Pure Silver"
                    ,
                                     Image = "Acer Aspire 3.jpg"
                    ,
                                     Price = 36999M
                    ,
                                     Section = "Laptop"
                                 }


             );
            #endregion

            #region headphone

            builder.HasData
              (
                 new Product
                 {
                     Id = 18,
                     Name = "soundcore by Anker Q20i Hybrid Active Noise Cancelling Headphones, Wireless Over-Ear Bluetooth, 40H Long ANC Playtime, Hi-Res Audio, Big Bass, Customize via an App, Transparency Mode, Ideal for Travel0",
                     Image = "610NdWdTLiL._AC._SR360,460.jpg",
                     Section = "Headphone",
                     Price = 3079M

                 },
                  new Product
                  {
                      Id = 19,
                      Name = "Soundcore by Anker Space Q45 Adaptive Active Noise Cancelling Headphones, Reduce Noise by Up to 98%, 50H Playtime, App Control, LDAC Hi-Res Wireless Audio, Clear Calls",
                      Image = "51WKQefGB2L.__AC_SX300_SY300_QL70_ML2_.jpg",
                      Section = "Headphone",
                      Price = 6999M

                  },

                  new Product
                  {
                      Id = 20,
                      Name = "Sennheiser HD 350BT Bluetooth 5.0 Wireless Headphone - 30-Hour Battery Life, USB-C Fast Charging, Virtual Assistant Button, Foldable - Black Headphones Headset",
                      Image = "51eVTenDv1S._AC_SX522_.jpg",
                      Section = "Headphone",
                      Price = 5500M
                  },
                  new Product
                  {
                      Id = 21,
                      Name = "Soundcore by Anker, Space One, Active Noise Cancelling Headphones, 2X Stronger Voice Reduction, 40H ANC Playtime, App Control, LDAC Hi-Res Wireless Audio, Comfortable Fit, Clear Calls, Bluetooth 5.3",
                      Image = "51fuWXGITfL._AC_SX522_.jpg",
                      Section = "Headphone",
                      Price = 5499M
                  },
                  new Product
                  {
                      Id = 22,
                      Name = "Soundcore by Anker, Space One, Active Noise Cancelling Headphones, 2X Stronger Voice Reduction, 40H ANC Playtime, App Control, LDAC Hi-Res Wireless Audio, Comfortable Fit, Clear Calls, Bluetooth 5.3",
                      Image = "610NdWdTLiL._AC._SR360,460.jpg",
                      Section = "Headphone",
                      Price = 5079M
                  },

                  new Product
                  {
                      Id = 23,
                      Name = "Sony mdrzx110apblack wired headphones - black Headset Wired",
                      Image = "71ozyM-GtML.__AC_SX300_SY300_QL70_ML2_.jpg",
                      Section = "Headphone",
                      Price = 2079M
                  },
                  new Product
                  {
                      Id = 24,
                      Name = "Sodo 1006 Bluetooth Headphone Black, Wireless",
                      Image = "51INnja74SS._AC_SX522_.jpg",
                      Section = "Headphone",
                      Price = 3900
                  },
                  new Product
                  {
                      Id = 25,
                      Name = "Onikuma k20 stereo rgb gaming headset with led light noise-cancelling mic for mobile/pc/ps4/xbox one/mac, black, Wired",
                      Image = "71V2OAFXmnL._AC_SX522_.jpg",
                      Section = "Headphone",
                      Price = 800
                  }

              );

            #endregion

            #region Phones
            builder.HasData
                (
                   new Product
                   {
                       Id = 26,
                       Name = "Samsung Galaxy A54 - Dual SIM Mobile Phone Android, 8GB RAM, 256GB, Awesome Graphite - 1 year Warranty",
                       Image = "71xU8w3fHJL.__AC_SX300_SY300_QL70_ML2_.jpg",
                       Price = 19500M,
                       Section = "Phone"
                   },
                    new Product
                    {
                        Id = 27,
                        Name = "SAMSUNG Galaxy S24 Ultra, AI Android Smartphone, 256GB Storage, 12GB RAM, 200MP Camera, S Pen, Long Battery Life - Titanium Black",
                        Image = "719HV2e6-sL.__AC_SY300_SX300_QL70_ML2_.jpg",
                        Price = 66500M,
                        Section = "Phone"
                    },
                    new Product
                    {
                        Id = 28,
                        Name = "Samsung Galaxy A54 Dual SIM 8GB Ram+256GB ROM (6.23 Inches) (5G) - (Awesome Lime)",
                        Image = "716FwKy9FlL._AC_SX522_.jpg",
                        Price = 19999M,
                        Section = "Phone"
                    },
                    new Product
                    {
                        Id = 29,
                        Name = "Samsung Galaxy A05 LTE, Android Smartphone, Dual SIM Mobile Phone, 4GB RAM, 64GB Storage, Black",
                        Image = "S300871866_1.jpeg",
                        Price = 11500M,
                        Section = "Phone"
                    },
                    new Product
                    {
                        Id = 30,
                        Name = "Xiaomi Redmi Note 12 128GB Onyx Grey 4G Smartphone",
                        Image = "S300852888_1.jpeg",
                        Price = 10500M,
                        Section = "Phone"
                    },
                    new Product
                    {
                        Id = 31,
                        Name = "Apple iPhone 14 (128GB) – Midnight",
                        Image = "IPHONE14_midnight_1.jpeg",
                        Price = 47500M,
                        Section = "Phone"
                    },
                    new Product
                    {
                        Id = 32,
                        Name = "Apple iPhone 15 Pro Max 5G",
                        Image = "iphone-15-pro-blue_titanium_5.jpg",
                        Price = 89100M,
                        Section = "Phone"
                    },
                    new Product
                    {
                        Id = 33,
                        Name = "Apple iPhone 14 Pro Max ",
                        Image = "apple-iphone-14-pro-max-2.jpg",
                        Price = 50500M,
                        Section = "Phone"
                    },
                    new Product
                    {
                        Id = 34,
                        Name = "Oppo Find X7 Ultra",
                        Image = "Oppo-Find-X7-Ultra-1.jpg",
                        Price = 20500M,
                        Section = "Phone"
                    },
                    new Product
                    {
                        Id = 35,
                        Name = "Oppo Reno 11 Pro 5G",
                        Image = "Oppo-Reno11-Pro-5G.jpg",
                        Price = 19500M,
                        Section = "Phone"
                    },
                    new Product
                    {
                        Id = 36,
                        Name = "Samsung Galaxy A54 - Dual SIM Mobile Phone Android, 8GB RAM, 256GB, Awesome Graphite - 1 year Warranty",
                        Image = "8164n7bBeSL.__AC_SX300_SY300_QL70_ML2_.jpg",
                        Price = 17500M,
                        Section = "Phone"
                    },
                    new Product
                    {
                        Id = 37,
                        Name = "Realme 9 Pro Dual SIM Smartphone, 8GB RAM, 128GB ROM, 5G LTE - Green",
                        Image = "61EjSPXLvNL.__AC_SX300_SY300_QL70_ML2_.jpg",
                        Price = 9500M,
                        Section = "Phone"
                    },
                    new Product
                    {
                        Id = 38,
                        Name = "realme 12 Pro 5G (Submarine Blue, 12GB RAM, 512GB Storage) | 50 MP Sony IMX882 OIS Camera | 32 MP 2X Flagship Telephoto Portrait | Snapdragon 6 Gen 1 | Curved Vision Display | 8 GB+12 GB Dynamic RAM",
                        Image = "81QvAGRjTAL.__AC_SX300_SY300_QL70_ML2_.jpg",
                        Price = 19500M,
                        Section = "Phone"
                    },
                    new Product
                    {
                        Id = 39,
                        Name = "Realme C 55 - (8G) - (256G) - Sunshower",
                        Image = "81tZSD6b3UL._AC_SX522_.jpg",
                        Price = 17500M,
                        Section = "Phone"
                    },
                    new Product
                    {
                        Id = 40,
                        Name = "Realme 11 Pro Dual-SIM 256GB ROM + 8GB RAM 5G (Astral Black), Bluetooth, Wi-Fi",
                        Image = "61GpBQyT0nL._AC_SY679_.jpg",
                        Price = 17500M,
                        Section = "Phone"
                    }

                );
            #endregion

            #region Cameras

            builder.HasData
             (
               new Product
               {
                   Id = 41,
                   Name = "Canon EOS 2000D DSLR camera with EFS with 18-55mm III lens kit",
                   Image = "81RLTx5tIUL._AC_SX679_.jpg",
                   Price = 39500M,
                   Section = "Camera"
               },
               new Product
               {
                   Id = 42,
                   Name = "CANON EOS R10 + RF-S 18-150mm F3.5-6.3 IS STM",
                   Image = "71g4FvN5GpL.__AC_SY300_SX300_QL70_ML2_.jpg",
                   Price = 64500M,
                   Section = "Camera"
               },
               new Product
               {
                   Id = 43,
                   Name = "Canon eos 5d mark iv body only - 30.4mp, dslr camera, black",
                   Image = "615OJvN6vDL._AC_SX679_.jpg",
                   Price = 116000M,
                   Section = "Camera"
               },
               new Product
               {
                   Id = 44,
                   Name = "D.CAM EOS R50 BK + RFS18-45 S EU26",
                   Image = "614AP9gOSoL._AC_SX522_.jpg",
                   Price = 55500M,
                   Section = "Camera"
               },
               new Product
               {
                   Id = 45,
                   Name = "Fujifilm X-T5 Mirrorless Digital Camera XF18-55mm Lens Kit - Silver",
                   Image = "81MIfOe5BkL._AC_SX679_.jpg",
                   Price = 109500M,
                   Section = "Camera"
               },
               new Product
               {
                   Id = 46,
                   Name = "Canon Powershot V10 Advanced Vlogging Kit, Black",
                   Image = "61tHZOb2WgL.__AC_SX300_SY300_QL70_ML2_.jpg",
                   Price = 18500M,
                   Section = "Camera"
               },
               new Product
               {
                   Id = 47,
                   Name = "EOS 250D BK 18-55 IS CP EU26",
                   Image = "61YoJJ0LuPL._AC_SX679_.jpg",
                   Price = 39500M,
                   Section = "Camera"
               },
               new Product
               {
                   Id = 48,
                   Name = "Kids Childrens Digital Video Camera, Point and Shoot Digital Camera for Kids Childrens(pink)",
                   Image = "81RLTx5tIUL._AC_SX679_.jpg",
                   Price = 2500M,
                   Section = "Camera"
               },
               new Product
               {
                   Id = 49,
                   Name = "Viltrox af 23mm f/1.4 z lens for nikon z (black)",
                   Image = "71flcOVmxZL.__AC_SX300_SY300_QL70_ML2_.jpg",
                   Price = 13500M,
                   Section = "Camera"
               },
               new Product
               {
                   Id = 50,
                   Name = "Sigma 105mm F2.8 EX DG OS HSM Macro Lens For Canon",
                   Image = "61VylL5mjBL._AC_SY879_.jpg",
                   Price = 45000M,
                   Section = "Camera"
               }

             );
            #endregion

            #region New Product

            builder.HasData
              (
                  new Product
                  {
                      Id = 16,
                      Name = "Mac-book Pro 16-inch\n-12-Core CPU18-Core GPU 36GB Unified Memory 512GB SSD Storage¹",
                      Image = "mbp16-spaceblack-select-202310.jpeg",
                      Price = 50000M,
                      Section = "Laptop",
                      Status = "New"
                  },
                  new Product
                  {
                      Id = 17,
                      Name = "Mac-book Pro 16-inch\n-12-Core CPU18-Core GPU 36GB Unified Memory 512GB SSD Storage¹",
                      Image = "mbp14-spacegray-select-202310.jpeg",
                      Price = 45000M,
                      Section = "Laptop",
                      Status = "New"
                  },
                  new Product
                  {
                      Id = 52,
                      Name = "Eksa T8 Ps4 Gaming Wired Over Ear Headphones With Mic With Noise Canceling, Pc With Surround Stereo Sound, Led Light For Ps4, Pc, Laptop (Blue)",
                      Image = "product02.png",
                      Price = 400M,
                      Section = "Headphone",
                      Status = "New"
                  },
                   new Product
                   {
                       Id = 53,
                       Name = "KBP 500s Wireless Headphones Bluetooth Headset",
                       Image = "416Mhs3IZ3L._AC_.jpg",
                       Price = 200M,
                       Section = "Headphone",
                       Status = "New"
                   },
                   new Product
                   {
                       Id = 54,
                       Name = "HUAWEI FreeBuds SE 2, 40-Hour Battery Life, Compact and Comfortable to Grip, 3 Hours of Music Playback on a 10-Minute Charge, IP54 Dust & Splash Resistance, Robust Bluetooth 5.3 Connections, Blue",
                       Image = "51HX-8O1wIL.__AC_SX300_SY300_QL70_ML2_.jpg",
                       Price = 2000M,
                       Section = "Headphone",
                       Status = "New"
                   }
              );
            #endregion

            #region TopSelling
            builder.HasData
                (
                   new Product
                   {
                       Id = 55,
                       Name = "JBL Endurance Run Sweatproof Wired Sports In-Ear Headphones - Black earphones Airpods earbuds headphones",
                       Image = "51roQPeJe0L._AC_SX522_.jpg",
                       Price = 1000M,
                       Section = "Headphone",
                       Status = "TopSelling"
                   },
                   new Product
                   {
                       Id = 56,
                       Name = "Canon XA11 Camcorder Power Kit with Additional Battery BP-820",
                       Image = "81I1dz5PCBL.__AC_SY300_SX300_QL70_ML2_.jpg",
                       Price = 50200M,
                       Section = "Camera",
                       Status = "TopSelling"
                   },
                   new Product
                   {
                       Id = 57,
                       Name = "Samsung Galaxy A15 Dual SIM 8GB Ram+256GGB ROM (6.5 Inches) (4G LTE) - (Black)",
                       Image = "514nSB8S9pL._AC_SX522_.jpg",
                       Price = 7000M,
                       Section = "Phone",
                       Status = "TopSelling"
                   },
                   new Product
                   {
                       Id = 58,
                       Name = "Lenovo ThinkPad L13 Yoga Gen2 2n1 Laptop - Intel Core i5-1135G7, 16GB RAM, 512GB SSD, Intel Iris Xe Graphics, 13.3\" FHD (1920x1080) IPS 300nits Multi-touch, FingerPrint, Win 10 Pro +ThinkPad Pen Pro",
                       Image = "51FmZTizmyL.__AC_SY300_SX300_QL70_ML2_.jpg",
                       Price = 37200M,
                       Section = "Laptop",
                       Status = "TopSelling"
                   },
                   new Product
                   {
                       Id = 59,
                       Name = "PRO 2ND GEN WIRELESS AIR PHONES characterized by semi-orignal POP-UP FEATURE (Black Edition) (Version Pro 2)",
                       Image = "61VtknlLe7L.__AC_SX300_SY300_QL70_ML2_.jpg",
                       Price = 700M,
                       Section = "Headphone",
                       Status = "TopSelling"
                   },
                   new Product
                   {
                       Id = 60,
                       Name = "Honor 90 12GB 512GB Diamond Silver",
                       Image = "honor_90_12gb_512gb_diamond_silver.jpg",
                       Price = 26500M,
                       Section = "Phone",
                       Status = "TopSelling"
                   }

                );
            #endregion
        }
    }
}
