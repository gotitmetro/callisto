﻿﻿//
// Copyright (c) 2012 Tim Heuer
//
// Licensed under the Microsoft Public License (Ms-PL) (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://opensource.org/licenses/Ms-PL.html
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Callisto.Converters
{
    public class ColorBrightnessConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            // parameter should be the brightness factor in double.
            var factor = System.Convert.ToDouble(parameter);
            var brush = (SolidColorBrush)value;

            var newColor = new Color() { A = brush.Color.A, B = System.Convert.ToByte(brush.Color.B * factor), G = System.Convert.ToByte(brush.Color.G * factor), R = System.Convert.ToByte(brush.Color.R * factor) };

            return new SolidColorBrush(newColor);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return value;
        }
    }
}
