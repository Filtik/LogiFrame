﻿using System;

namespace LogiFrame
{
    /// <summary>
    /// Represents the technique used for transforming a System.Drawing.Bitmap
    /// into a LogiFrame.Bytemap. 
    /// </summary>
    public struct ConversionMethod
    {
        /// <summary>
        /// Represents the default conversion type.
        /// </summary>
        public static readonly ConversionMethod Normal = new ConversionMethod(0, 0, 0, 255);

        /// <summary>
        /// Represents a conversion where pixels with RGR values of 0-64 and A value of 255 are filled.
        /// </summary>
        public static readonly ConversionMethod QuarterByte = new ConversionMethod(64, 64, 64, 255);

        /// <summary>
        /// Represents a conversion where pixels with RGR values of 0-254 and A value of 255 are filled.
        /// </summary>
        public static readonly ConversionMethod NonWhite = new ConversionMethod(254, 254, 254, 255);

        /// <summary>
        /// The maximum red color value for a pixel to be filled.
        /// </summary>
        public byte MaxRed { get; set; }

        /// <summary>
        /// The maximum green color value for a pixel to be filled.
        /// </summary>
        public byte MaxGreen { get; set; }

        /// <summary>
        /// The maximum blue color value for a pixel to be filled.
        /// </summary>
        public byte MaxBlue { get; set; }

        /// <summary>
        /// The minimum alpha color value for a pixel to be filled.
        /// </summary>
        public byte MinAlpha { get; set; }

        /// <summary>
        /// Initializes a new instance of the LogiFrame.ConversionMethod structure.
        /// </summary>
        /// <param name="maxRed">The maximum red color value for a pixel to be filled.</param>
        /// <param name="maxGreen">The maximum green color value for a pixel to be filled.</param>
        /// <param name="maxBlue">The maximum blue color value for a pixel to be filled.</param>
        /// <param name="minAlpha">The minimum alpha color value for a pixel to be filled.</param>
        public ConversionMethod(byte maxRed, byte maxGreen, byte maxBlue, byte minAlpha)
            : this()
        {
            MaxRed = maxRed;
            MaxGreen = maxGreen;
            MaxBlue = maxBlue;
            MinAlpha = minAlpha;
        }

        /// <summary>
        /// Determines whether the specified System.Object is equal to the current LogiFrame.ConversionMethod.
        /// </summary>
        /// <param name="obj">The System.Object to compare with the current LogiFrame.ConversionMethod.</param>
        /// <returns>
        ///     true if the specified System.Object is equal to the current LogiFrame.ConversionMethod;
        ///     otherwise, false.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null || obj is ConversionMethod == false)
                return false;

            ConversionMethod other = (ConversionMethod)obj;

            return other.MaxBlue == MaxBlue &&
                   other.MaxGreen == MaxGreen &&
                   other.MaxRed == MaxRed &&
                   other.MinAlpha == MinAlpha;
        }

        public static bool operator ==(ConversionMethod left, ConversionMethod right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ConversionMethod left, ConversionMethod right)
        {
            return left.Equals(right) == false;
        }

        /// <summary>
        /// Returns a hash code for this LogiFrame.ConversionMethod.
        /// </summary>
        /// <returns>An integer value that specifies a hash value for this LogiFrame.ConversionMethod.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 37;
                result *= 397;
                result += MaxRed;
                result *= 397;
                result += MaxGreen;
                result *= 397;
                result += MaxBlue;
                result *= 397;
                result += MinAlpha;
                return result;
            }
        }
    }
}