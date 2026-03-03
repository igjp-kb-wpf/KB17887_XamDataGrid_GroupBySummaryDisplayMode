using System.Collections.Generic;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GridRight.DataSource = CreateSampleData();
        }

        private List<SalesItem> CreateSampleData()
        {
            return new List<SalesItem>
            {
                // 2026/04 — 6件
                new SalesItem { MONTH = "2026/04", COMPANY_NAME = "A商事㈱",   PRODUCT_NAME = "製品X", QUANTITY = 1200, AMOUNT = 80 },
                new SalesItem { MONTH = "2026/04", COMPANY_NAME = "B工業㈱",   PRODUCT_NAME = "製品Y", QUANTITY =  850, AMOUNT = 55 },
                new SalesItem { MONTH = "2026/04", COMPANY_NAME = "C製作所㈱", PRODUCT_NAME = "製品Z", QUANTITY = 2300, AMOUNT = 140 },
                new SalesItem { MONTH = "2026/04", COMPANY_NAME = "D物産㈱",   PRODUCT_NAME = "製品X", QUANTITY =  620, AMOUNT = 42 },
                new SalesItem { MONTH = "2026/04", COMPANY_NAME = "E技研㈱",   PRODUCT_NAME = "製品W", QUANTITY = 1750, AMOUNT = 110 },
                new SalesItem { MONTH = "2026/04", COMPANY_NAME = "F素材㈱",   PRODUCT_NAME = "製品Y", QUANTITY =  980, AMOUNT = 63 },

                // 2026/05 — 4件
                new SalesItem { MONTH = "2026/05", COMPANY_NAME = "A商事㈱",   PRODUCT_NAME = "製品Z", QUANTITY = 1100, AMOUNT = 72 },
                new SalesItem { MONTH = "2026/05", COMPANY_NAME = "B工業㈱",   PRODUCT_NAME = "製品X", QUANTITY = 3200, AMOUNT = 200 },
                new SalesItem { MONTH = "2026/05", COMPANY_NAME = "G部品㈱",   PRODUCT_NAME = "製品W", QUANTITY =  450, AMOUNT = 30 },
                new SalesItem { MONTH = "2026/05", COMPANY_NAME = "H材料㈱",   PRODUCT_NAME = "製品Y", QUANTITY = 1600, AMOUNT = 98 },

                // 2026/06 — 3件
                new SalesItem { MONTH = "2026/06", COMPANY_NAME = "C製作所㈱", PRODUCT_NAME = "製品X", QUANTITY = 2800, AMOUNT = 175 },
                new SalesItem { MONTH = "2026/06", COMPANY_NAME = "D物産㈱",   PRODUCT_NAME = "製品Z", QUANTITY =  730, AMOUNT = 48 },
                new SalesItem { MONTH = "2026/06", COMPANY_NAME = "A商事㈱",   PRODUCT_NAME = "製品W", QUANTITY = 1950, AMOUNT = 122 },
            };
        }
    }
}