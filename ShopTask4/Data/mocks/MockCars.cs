﻿namespace ShopTask4.Data.mocks
{
    using ShopTask4.Data.interfaces;
    using ShopTask4.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MockCars
    {
        private readonly ICarsCategory categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car> {
                    new Car { Name = "Tesla",
                              ShortDescription = "Tesla’s mission is to accelerate the world’s transition to sustainable energy.",
                              LongDescription = "Tesla was founded in 2003 by a group of engineers who wanted to prove that people didn’t need to compromise to drive electric – that electric vehicles can be better, quicker and more fun to drive than gasoline cars. Today, Tesla builds not only all-electric vehicles but also infinitely scalable clean energy generation and storage products. Tesla believes the faster the world stops relying on fossil fuels and moves towards a zero-emission future, the better.",
                              Image = "/img/Tesla-Model-S-2gen.jpg",
                              Price = 45000,
                              IsFavourite = true,
                              Avaitable = true,
                              Category = categoryCars.AllCategories.First(),
                             },

                     new Car { Name = "BMV X2",
                              ShortDescription = "Bayerische Motoren Werke AG, commonly known as Bavarian Motor Works, BMW or BMW AG, is a German automobile, motorcycle and engine manufacturing company founded in 1916.",
                              LongDescription = "The first car which BMW successfully produced and the car which launched BMW on the road to automobile production was the Dixi, it was based on the Austin 7 and licensed from the Austin Motor Company in Birmingham, England.",
                              Image = "/img/2019-bmw-x2-m35i.jpg",
                              Price = 12000,
                              IsFavourite = true,
                              Avaitable = true,
                              Category = categoryCars.AllCategories.Last(),
                             },

                      new Car { Name = "BMV I3 Tera",
                              ShortDescription = "BMW i3 не следует ни одной тенденции; он являет собой выражение самоосознающего образа жизни.",
                              LongDescription = "Присоединяйтесь и испытывайте будущее на кончиках ваших пальцев. BMW i3 полон инновационных технологий, которые он использует для уверенного освоения вашей повседневной жизни. Он соединяет вас с внешним миром, оповещает вас о том, что происходит вокруг, держит вас организованным и направляет вас настолько далеко, насколько вы этого хотите. Он всегда готов к дороге и исследует новые пути. Со стилем и трендовым дизайном для электрификации удовольствия от вождения.",
                              Image = "/img/IMG_0578.jpg",
                              Price = 25000,
                              IsFavourite = false,
                              Avaitable = true,
                              Category = categoryCars.AllCategories.First(),
                             }
                   };
            }
             }
        public IEnumerable<Car> GetFavoriteCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Car GetCar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
