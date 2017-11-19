﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbookReader.Model.View {
    public class SettingsControlVM : BaseVM {
        public bool ClickEverywhere {
            get => UserSettings.Control.ClickEverywhere;
            set {
                if (UserSettings.Control.ClickEverywhere == value)
                    return;

                UserSettings.Control.ClickEverywhere = value;
                OnPropertyChanged();
            }
        }
    }
}
