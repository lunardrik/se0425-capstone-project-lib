using System;
using System.Collections.Generic;
using System.Threading;
using DevExpress.XtraBars.Alerter;

namespace LIB
{
    class Refresher
    {
        private RegisterRentalForm _registerRentalForm;
        private static Feature _feature;
        private List<BookRegisterDTO> _listNewRegister;

        public int RefreshInterval { get; set; }
        public DateTime LastUpdateTime { get; set; }

        public Refresher(Feature feature, RegisterRentalForm registerRentalForm)
        {
            _registerRentalForm = registerRentalForm;
            _feature = feature;
            _listNewRegister = new List<BookRegisterDTO>();
            LastUpdateTime = DateTime.Now;
            RefreshInterval = 10 * 1000;
        }
        public void GetNewRegister()
        {
            while (true)
            {
                try
                {
                    Thread.Sleep(RefreshInterval);
                    Console.WriteLine("getting new register");
                    _listNewRegister = _feature.GetNewRegister(LastUpdateTime);
                    foreach (var bookRegisterDto in _listNewRegister)
                    {
                        Console.WriteLine("there is a new register");
                        string info = "\t Người yêu cầu: " + bookRegisterDto.Username + "\n" + 
                            "\t Tên tài liệu: " + bookRegisterDto.BookTitle;
                        _registerRentalForm.Alert(info);
                    }
                }
                catch (Exception e)
                {
                    Log.Logger.Error("Error at Refresher - GetNewRegister", e);
                }
            }
        }
    }
}
