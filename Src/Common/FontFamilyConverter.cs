﻿// Copyright © Microsoft Corporation. 
// This source is subject to the Microsoft Source License for Silverlight Controls (March 2008 Release).
// Please see http://go.microsoft.com/fwlink/?LinkID=111693 for details.
// All other rights reserved. 

using System;
using System.ComponentModel; 
using System.Windows.Controlsb1;
using System.Windows.Media;

namespace System.Windows.Mediab1
{
    /// <summary>
    /// Converts instances of the String type to FontFamily instances. 
    /// </summary>
    public sealed partial class FontFamilyConverter : TypeConverter
    { 
        /// <summary> 
        /// Initializes a new instance of the FontFamilyConverter class.
        /// </summary> 
        public FontFamilyConverter()
        {
        } 

        /// <summary>
        /// Returns a value that indicates whether this converter can convert an 
        /// object of the given type to an instance of FontFamily. 
        /// </summary>
        /// <param name="sourceType"> 
        /// The type of the source that is being evaluated for conversion.
        /// </param>
        /// <returns> 
        /// true if the converter can convert the provided type to an instance
        /// of FontFamily; otherwise, false.
        /// </returns> 
        public override bool CanConvertFrom(Type sourceType) 
        {
            return TypeConverters.CanConvertFrom<FontFamily>(sourceType); 
        }

        /// <summary> 
        /// Attempts to convert a specified object to an instance of FontFamily.
        /// </summary>
        /// <param name="value">The object being converted.</param> 
        /// <returns> 
        /// The instance of FontFamily created from the converted object.
        /// </returns> 
        public override object ConvertFrom(object value)
        {
            return TypeConverters.ConvertFrom<FontFamily>(this, value); 
        }

        /// <summary> 
        /// Attempts to convert a specified String to an instance of FontFamily. 
        /// </summary>
        /// <param name="text"> 
        /// The String to be converted into the FontFamily object.
        /// </param>
        /// <returns> 
        /// The instance of FontFamily created from the converted text.
        /// </returns>
        public override object ConvertFromString(string text) 
        { 
            return new FontFamily(text);
        } 
    }
}
