using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CianTest
{
    internal class FilterTest : TestBase
    {
        [Test]
        public void SearchResult()
        {
            MainPageYa mainPageYa = new MainPageYa(driver); //объект класса MainPageYa, который представляет собой страницу Яндекс.
            MainPageCian mainPageCian = new MainPageCian(driver);  //объект класса MainPageCian, который представляет собой сайт ЦИАН. 
            mainPageYa.SearchItem("ЦИАН"); //выполняет поиск элемента с текстом «ЦИАН» на странице Яндекс.
            mainPageYa.PopUpWindow(); //закрывает всплывающее окно.
            mainPageYa.SwitchingToCian(); //переключается на сайт ЦИАН.
            mainPageCian.TakeOffBtnClick(); //нажимает кнопку «Снять» на сайте ЦИАН.
            mainPageCian.SearchPageItem("Буммаш"); //ищет элемент с текстом «Буммаш» на поисковой странице ЦИАН.
            mainPageCian.SearchBtnClick(); //нажимает кнопку поиска на поисковой странице ЦИАН.


        }
    }
}
