﻿using GemstonesBusinessManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace GemstonesBusinessManagementSystem.ViewModels
{
    class HomeViewModel : BaseViewModel
    {
        public ICommand NavigateCommand { get; set; }
        public ICommand GetUidCommand { get; set; }

        private string uid;
        public HomeViewModel()
        {
            NavigateCommand = new RelayCommand<MainWindow>((p) => true, (p) => Navigate(p));
            GetUidCommand = new RelayCommand<Button>((p) => true, (p) => uid = p.Uid);
        }
        void Navigate(MainWindow window)
        {
            int index = int.Parse(uid);

            window.grdEmployee.Visibility = Visibility.Collapsed;
            window.grdGoods.Visibility = Visibility.Collapsed;
            window.grdService.Visibility = Visibility.Collapsed;
            window.grdCustomer.Visibility = Visibility.Collapsed;
            window.grdSupplier.Visibility = Visibility.Collapsed;
            window.grdInvoice.Visibility = Visibility.Collapsed;

            string fore = "#666666";
            string back = "#FFFFFF";
            string foreFocus = "#FFF5D577";
            string backFocus = "#FF00329E";

            window.btnHome.Foreground = (Brush)new BrushConverter().ConvertFrom(fore);
            window.btnStore.Foreground = (Brush)new BrushConverter().ConvertFrom(fore);
            window.btnService.Foreground = (Brush)new BrushConverter().ConvertFrom(fore);
            window.btnStock.Foreground = (Brush)new BrushConverter().ConvertFrom(fore);
            window.btnImport.Foreground = (Brush)new BrushConverter().ConvertFrom(fore);
            window.btnSupplier.Foreground = (Brush)new BrushConverter().ConvertFrom(fore);
            window.btnCustomer.Foreground = (Brush)new BrushConverter().ConvertFrom(fore);
            window.btnEmployee.Foreground = (Brush)new BrushConverter().ConvertFrom(fore);
            window.btnGoods.Foreground = (Brush)new BrushConverter().ConvertFrom(fore);
            window.btnServiceM.Foreground = (Brush)new BrushConverter().ConvertFrom(fore);
            window.btnNote.Foreground = (Brush)new BrushConverter().ConvertFrom(fore);
            window.btnRevenue.Foreground = (Brush)new BrushConverter().ConvertFrom(fore);

            window.btnHome.Background = (Brush)new BrushConverter().ConvertFrom(back);
            window.btnStore.Background = (Brush)new BrushConverter().ConvertFrom(back);
            window.btnService.Background = (Brush)new BrushConverter().ConvertFrom(back);
            window.btnStock.Background = (Brush)new BrushConverter().ConvertFrom(back);
            window.btnImport.Background = (Brush)new BrushConverter().ConvertFrom(back);
            window.btnSupplier.Background = (Brush)new BrushConverter().ConvertFrom(back);
            window.btnCustomer.Background = (Brush)new BrushConverter().ConvertFrom(back);
            window.btnEmployee.Background = (Brush)new BrushConverter().ConvertFrom(back);
            window.btnGoods.Background = (Brush)new BrushConverter().ConvertFrom(back);
            window.btnServiceM.Background = (Brush)new BrushConverter().ConvertFrom(back);
            window.btnNote.Background = (Brush)new BrushConverter().ConvertFrom(back);
            window.btnRevenue.Background = (Brush)new BrushConverter().ConvertFrom(back);

            switch (index)
            {
                //home
                case 0:
                    window.btnHome.Foreground = (Brush)new BrushConverter().ConvertFrom(foreFocus);
                    window.btnHome.Background = (Brush)new BrushConverter().ConvertFrom(backFocus);
                    break;

                //bán hàng
                case 10:
                    CloseExpander(window, 0);
                    window.btnStore.Foreground = (Brush)new BrushConverter().ConvertFrom(foreFocus);
                    window.btnStore.Background = (Brush)new BrushConverter().ConvertFrom(backFocus);
                    break;
                //dịch vụ
                case 11:
                    CloseExpander(window, 0);
                    window.btnService.Foreground = (Brush)new BrushConverter().ConvertFrom(foreFocus);
                    window.btnService.Background = (Brush)new BrushConverter().ConvertFrom(backFocus);
                    break;

                //tồn kho
                case 20:
                    CloseExpander(window, 1);
                    window.btnStock.Foreground = (Brush)new BrushConverter().ConvertFrom(foreFocus);
                    window.btnStock.Background = (Brush)new BrushConverter().ConvertFrom(backFocus);
                    break;
                //nhập hàng
                case 21:
                    CloseExpander(window, 1);
                    window.btnImport.Foreground = (Brush)new BrushConverter().ConvertFrom(foreFocus);
                    window.btnImport.Background = (Brush)new BrushConverter().ConvertFrom(backFocus);
                    break;

                //nhà cc
                case 30:
                    window.grdSupplier.Visibility = Visibility.Visible;
                    CloseExpander(window, 2);
                    window.btnSupplier.Foreground = (Brush)new BrushConverter().ConvertFrom(foreFocus);
                    window.btnSupplier.Background = (Brush)new BrushConverter().ConvertFrom(backFocus);
                    break;
                //khách hàng
                case 31:
                    window.grdCustomer.Visibility = Visibility.Visible;
                    CloseExpander(window, 2);
                    window.btnCustomer.Foreground = (Brush)new BrushConverter().ConvertFrom(foreFocus);
                    window.btnCustomer.Background = (Brush)new BrushConverter().ConvertFrom(backFocus);
                    break;

                //ql nhân viên
                case 40:
                    window.grdEmployee.Visibility = Visibility.Visible;
                    CloseExpander(window, 3);
                    window.btnEmployee.Background = (Brush)new BrushConverter().ConvertFrom(backFocus);
                    window.btnEmployee.Foreground = (Brush)new BrushConverter().ConvertFrom(foreFocus);
                    break;
                //ql hàng hóa
                case 41:
                    window.grdGoods.Visibility = Visibility.Visible;
                    CloseExpander(window, 3);
                    window.btnGoods.Foreground = (Brush)new BrushConverter().ConvertFrom(foreFocus);
                    window.btnGoods.Background = (Brush)new BrushConverter().ConvertFrom(backFocus);
                    break;
                //ql dịch vụ
                case 42:
                    window.grdService.Visibility = Visibility.Visible;
                    CloseExpander(window, 3);
                    window.btnServiceM.Foreground = (Brush)new BrushConverter().ConvertFrom(foreFocus);
                    window.btnServiceM.Background = (Brush)new BrushConverter().ConvertFrom(backFocus);
                    break;

                //báo cáo phiếu
                case 50:
                    window.grdInvoice.Visibility = Visibility.Visible;
                    CloseExpander(window, 4);
                    window.btnNote.Foreground = (Brush)new BrushConverter().ConvertFrom(foreFocus);
                    window.btnNote.Background = (Brush)new BrushConverter().ConvertFrom(backFocus);
                    break;
                //báo cáo doanh thu
                case 51:
                    CloseExpander(window, 4);
                    window.btnRevenue.Foreground = (Brush)new BrushConverter().ConvertFrom(foreFocus);
                    window.btnRevenue.Background = (Brush)new BrushConverter().ConvertFrom(backFocus);
                    break;
            }
        }
        void CloseExpander(MainWindow window, int index)
        {
            switch (index)
            {
                case 0:
                    window.expWarehouse.IsExpanded = false;
                    window.expPartner.IsExpanded = false;
                    window.expManage.IsExpanded = false;
                    window.expReport.IsExpanded = false;
                    break;
                case 1:
                    window.expStore.IsExpanded = false;
                    window.expPartner.IsExpanded = false;
                    window.expManage.IsExpanded = false;
                    window.expReport.IsExpanded = false;
                    break;
                case 2:
                    window.expStore.IsExpanded = false;
                    window.expWarehouse.IsExpanded = false;
                    window.expManage.IsExpanded = false;
                    window.expReport.IsExpanded = false;
                    break;
                case 3:
                    window.expStore.IsExpanded = false;
                    window.expWarehouse.IsExpanded = false;
                    window.expPartner.IsExpanded = false;
                    window.expReport.IsExpanded = false;
                    break;
                case 4:
                    window.expStore.IsExpanded = false;
                    window.expWarehouse.IsExpanded = false;
                    window.expPartner.IsExpanded = false;
                    window.expManage.IsExpanded = false;
                    break;
            }
        }
    }
}