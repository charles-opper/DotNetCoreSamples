using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Samples.StringFormatting
{
    public class StringFormats
    {
        public StringFormats()
        {
            _myName = "Charles Opper";
            _currentTime = DateTime.Now;
            _dayOfWeek = _currentTime.DayOfWeek;
        }

        public string FormatUsingInterpolation()
        {
            const int FieldWidthRightAligned = 20;
            return $"Hello, my name is { _myName } and today is { _dayOfWeek }. The current time is { _currentTime:HH:mm}.\n" +
                    $"The value of pie to three decimal digits is still...{Math.PI,FieldWidthRightAligned:F3}";
        }

        public string FormatUsingComposite()
        {
            return string.Format("Hello, my name is {0} and today is {1}. The current time is {2:HH:mm}.\n" +
                "The value of pie to three decimal digits is still...{3,20:F3}", _myName, _dayOfWeek, _currentTime, Math.PI);
        }

        string _myName;
        DateTime _currentTime;
        DayOfWeek _dayOfWeek;
    }
}
