﻿/***************************************************************************
 * HebMorph - making Hebrew properly searchable
 * 
 *   Copyright (C) 2010-2012                                               
 *      Itamar Syn-Hershko <itamar at code972 dot com>
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Affero General Public License for more details.
 * 
 * You should have received a copy of the GNU Affero General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */

using System;

namespace HebMorph.HSpell
{
    internal sealed class Constants
    {
        public const string DictionaryFile = "hebrew.wgz";
        public const string PrefixesFile = DictionaryFile + ".prefixes";
        public const string StemsFile = DictionaryFile + ".stems";
        public const string DescFile = DictionaryFile + ".desc";
        public const string SizesFile = DictionaryFile + ".sizes";
        public const string DmasksFile = "dmask.c";
        public const byte MaxWordLength = 255;

        #region prefixes.c
        public static string[] prefixes_noH ={/*"",*/
"ב",
"בכ",
"ה",
"ו",
"וב",
"ובכ",
"וה",
"וכ",
"וכב",
"וככ",
"וכל",
"וכמ",
"וכמה",
"וכש",
"וכשב",
"וכשבכ",
"וכשה",
"וכשכ",
"וכשכב",
"וכשככ",
"וכשכל",
"וכשכמ",
"וכשכמה",
"וכשל",
"וכשלכ",
"וכשמ",
"וכשמה",
"וכשמכ",
"ול",
"ולכ",
"ולכש",
"ולכשב",
"ולכשבכ",
"ולכשה",
"ולכשכ",
"ולכשכב",
"ולכשככ",
"ולכשכל",
"ולכשכמ",
"ולכשכמה",
"ולכשל",
"ולכשלכ",
"ולכשמ",
"ולכשמה",
"ולכשמכ",
"ומ",
"ומה",
"ומכ",
"ומש",
"ומשב",
"ומשבכ",
"ומשה",
"ומשכ",
"ומשכב",
"ומשככ",
"ומשכל",
"ומשכמ",
"ומשכמה",
"ומשל",
"ומשלכ",
"ומשמ",
"ומשמה",
"ומשמכ",
"וש",
"ושב",
"ושבכ",
"ושה",
"ושכ",
"ושכב",
"ושככ",
"ושכל",
"ושכמ",
"ושכמה",
"ושכש",
"ושכשב",
"ושכשבכ",
"ושכשה",
"ושכשכ",
"ושכשכב",
"ושכשככ",
"ושכשכל",
"ושכשכמ",
"ושכשכמה",
"ושכשל",
"ושכשלכ",
"ושכשמ",
"ושכשמה",
"ושכשמכ",
"ושל",
"ושלכ",
"ושלכש",
"ושלכשב",
"ושלכשבכ",
"ושלכשה",
"ושלכשכ",
"ושלכשכב",
"ושלכשככ",
"ושלכשכל",
"ושלכשכמ",
"ושלכשכמה",
"ושלכשל",
"ושלכשלכ",
"ושלכשמ",
"ושלכשמה",
"ושלכשמכ",
"ושמ",
"ושמה",
"ושמכ",
"ושמש",
"ושמשב",
"ושמשבכ",
"ושמשה",
"ושמשכ",
"ושמשכב",
"ושמשככ",
"ושמשכל",
"ושמשכמ",
"ושמשכמה",
"ושמשל",
"ושמשלכ",
"ושמשמ",
"ושמשמה",
"ושמשמכ",
"כ",
"כב",
"ככ",
"כל",
"כמ",
"כמה",
"כש",
"כשב",
"כשבכ",
"כשה",
"כשכ",
"כשכב",
"כשככ",
"כשכל",
"כשכמ",
"כשכמה",
"כשל",
"כשלכ",
"כשמ",
"כשמה",
"כשמכ",
"ל",
"לכ",
"לכש",
"לכשב",
"לכשבכ",
"לכשה",
"לכשכ",
"לכשכב",
"לכשככ",
"לכשכל",
"לכשכמ",
"לכשכמה",
"לכשל",
"לכשלכ",
"לכשמ",
"לכשמה",
"לכשמכ",
"מ",
"מב",
"מה",
"מכ",
"מל",
"מש",
"משב",
"משבכ",
"משה",
"משכ",
"משכב",
"משככ",
"משכל",
"משכמ",
"משכמה",
"משל",
"משלכ",
"משמ",
"משמה",
"משמכ",
"ש",
"שב",
"שבכ",
"שה",
"שכ",
"שכב",
"שככ",
"שכל",
"שכמ",
"שכמה",
"שכש",
"שכשב",
"שכשבכ",
"שכשה",
"שכשכ",
"שכשכב",
"שכשככ",
"שכשכל",
"שכשכמ",
"שכשכמה",
"שכשל",
"שכשלכ",
"שכשמ",
"שכשמה",
"שכשמכ",
"של",
"שלכ",
"שלכש",
"שלכשב",
"שלכשבכ",
"שלכשה",
"שלכשכ",
"שלכשכב",
"שלכשככ",
"שלכשכל",
"שלכשכמ",
"שלכשכמה",
"שלכשל",
"שלכשלכ",
"שלכשמ",
"שלכשמה",
"שלכשמכ",
"שמ",
"שמה",
"שמכ",
"שמש",
"שמשב",
"שמשבכ",
"שמשה",
"שמשכ",
"שמשכב",
"שמשככ",
"שמשכל",
"שמשכמ",
"שמשכמה",
"שמשל",
"שמשלכ",
"שמשמ",
"שמשמה",
"שמשמכ", null};
        public static int[] masks_noH ={/*60,*/
43,
42,
32,
60,
43,
42,
32,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
32,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
44,
43,
42,
32,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
32,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
44,
43,
42,
32,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
32,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
-1};
        public static string[] prefixes_H ={/*"",*/
"ב",
"בכ",
"ה",
"הב",
"הבכ",
"הה",
"הכ",
"הכב",
"הככ",
"הכל",
"הכמ",
"הכמה",
"הכש",
"הכשב",
"הכשבכ",
"הכשה",
"הכשכ",
"הכשכב",
"הכשככ",
"הכשכל",
"הכשכמ",
"הכשכמה",
"הכשל",
"הכשלכ",
"הכשמ",
"הכשמה",
"הכשמכ",
"הל",
"הלכ",
"הלכש",
"הלכשב",
"הלכשבכ",
"הלכשה",
"הלכשכ",
"הלכשכב",
"הלכשככ",
"הלכשכל",
"הלכשכמ",
"הלכשכמה",
"הלכשל",
"הלכשלכ",
"הלכשמ",
"הלכשמה",
"הלכשמכ",
"המ",
"המה",
"המכ",
"המש",
"המשב",
"המשבכ",
"המשה",
"המשכ",
"המשכב",
"המשככ",
"המשכל",
"המשכמ",
"המשכמה",
"המשל",
"המשלכ",
"המשמ",
"המשמה",
"המשמכ",
"ו",
"וב",
"ובכ",
"וה",
"והב",
"והבכ",
"והה",
"והכ",
"והכב",
"והככ",
"והכל",
"והכמ",
"והכמה",
"והכש",
"והכשב",
"והכשבכ",
"והכשה",
"והכשכ",
"והכשכב",
"והכשככ",
"והכשכל",
"והכשכמ",
"והכשכמה",
"והכשל",
"והכשלכ",
"והכשמ",
"והכשמה",
"והכשמכ",
"והל",
"והלכ",
"והלכש",
"והלכשב",
"והלכשבכ",
"והלכשה",
"והלכשכ",
"והלכשכב",
"והלכשככ",
"והלכשכל",
"והלכשכמ",
"והלכשכמה",
"והלכשל",
"והלכשלכ",
"והלכשמ",
"והלכשמה",
"והלכשמכ",
"והמ",
"והמה",
"והמכ",
"והמש",
"והמשב",
"והמשבכ",
"והמשה",
"והמשכ",
"והמשכב",
"והמשככ",
"והמשכל",
"והמשכמ",
"והמשכמה",
"והמשל",
"והמשלכ",
"והמשמ",
"והמשמה",
"והמשמכ",
"וכ",
"וכב",
"וככ",
"וכל",
"וכמ",
"וכמה",
"וכש",
"וכשב",
"וכשבכ",
"וכשה",
"וכשכ",
"וכשכב",
"וכשככ",
"וכשכל",
"וכשכמ",
"וכשכמה",
"וכשל",
"וכשלכ",
"וכשמ",
"וכשמה",
"וכשמכ",
"ול",
"ולכ",
"ולכש",
"ולכשב",
"ולכשבכ",
"ולכשה",
"ולכשכ",
"ולכשכב",
"ולכשככ",
"ולכשכל",
"ולכשכמ",
"ולכשכמה",
"ולכשל",
"ולכשלכ",
"ולכשמ",
"ולכשמה",
"ולכשמכ",
"ומ",
"ומה",
"ומכ",
"ומש",
"ומשב",
"ומשבכ",
"ומשה",
"ומשכ",
"ומשכב",
"ומשככ",
"ומשכל",
"ומשכמ",
"ומשכמה",
"ומשל",
"ומשלכ",
"ומשמ",
"ומשמה",
"ומשמכ",
"וש",
"ושב",
"ושבכ",
"ושה",
"ושכ",
"ושכב",
"ושככ",
"ושכל",
"ושכמ",
"ושכמה",
"ושכש",
"ושכשב",
"ושכשבכ",
"ושכשה",
"ושכשכ",
"ושכשכב",
"ושכשככ",
"ושכשכל",
"ושכשכמ",
"ושכשכמה",
"ושכשל",
"ושכשלכ",
"ושכשמ",
"ושכשמה",
"ושכשמכ",
"ושל",
"ושלכ",
"ושלכש",
"ושלכשב",
"ושלכשבכ",
"ושלכשה",
"ושלכשכ",
"ושלכשכב",
"ושלכשככ",
"ושלכשכל",
"ושלכשכמ",
"ושלכשכמה",
"ושלכשל",
"ושלכשלכ",
"ושלכשמ",
"ושלכשמה",
"ושלכשמכ",
"ושמ",
"ושמה",
"ושמכ",
"ושמש",
"ושמשב",
"ושמשבכ",
"ושמשה",
"ושמשכ",
"ושמשכב",
"ושמשככ",
"ושמשכל",
"ושמשכמ",
"ושמשכמה",
"ושמשל",
"ושמשלכ",
"ושמשמ",
"ושמשמה",
"ושמשמכ",
"כ",
"כב",
"ככ",
"כל",
"כמ",
"כמה",
"כש",
"כשב",
"כשבכ",
"כשה",
"כשכ",
"כשכב",
"כשככ",
"כשכל",
"כשכמ",
"כשכמה",
"כשל",
"כשלכ",
"כשמ",
"כשמה",
"כשמכ",
"ל",
"לכ",
"לכש",
"לכשב",
"לכשבכ",
"לכשה",
"לכשכ",
"לכשכב",
"לכשככ",
"לכשכל",
"לכשכמ",
"לכשכמה",
"לכשל",
"לכשלכ",
"לכשמ",
"לכשמה",
"לכשמכ",
"מ",
"מב",
"מה",
"מכ",
"מל",
"מש",
"משב",
"משבכ",
"משה",
"משכ",
"משכב",
"משככ",
"משכל",
"משכמ",
"משכמה",
"משל",
"משלכ",
"משמ",
"משמה",
"משמכ",
"ש",
"שב",
"שבכ",
"שה",
"שכ",
"שכב",
"שככ",
"שכל",
"שכמ",
"שכמה",
"שכש",
"שכשב",
"שכשבכ",
"שכשה",
"שכשכ",
"שכשכב",
"שכשככ",
"שכשכל",
"שכשכמ",
"שכשכמה",
"שכשל",
"שכשלכ",
"שכשמ",
"שכשמה",
"שכשמכ",
"של",
"שלכ",
"שלכש",
"שלכשב",
"שלכשבכ",
"שלכשה",
"שלכשכ",
"שלכשכב",
"שלכשככ",
"שלכשכל",
"שלכשכמ",
"שלכשכמה",
"שלכשל",
"שלכשלכ",
"שלכשמ",
"שלכשמה",
"שלכשמכ",
"שמ",
"שמה",
"שמכ",
"שמש",
"שמשב",
"שמשבכ",
"שמשה",
"שמשכ",
"שמשכב",
"שמשככ",
"שמשכל",
"שמשכמ",
"שמשכמה",
"שמשל",
"שמשלכ",
"שמשמ",
"שמשמה",
"שמשמכ", null};
        public static int[] masks_H ={/*60,*/
43,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
32,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
60,
43,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
32,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
32,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
44,
43,
42,
32,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
32,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
44,
43,
42,
32,
42,
42,
42,
42,
42,
32,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
42,
32,
42,
44,
42,
42,
32,
42,
42,
42,
42,
42,
32,
42,
42,
42,
32,
42,
-1};
        #endregion
    }

    [Flags]
    public enum DMask : int
    {
        D_NOUN = 1,
        D_VERB = 2,
        D_ADJ = 3,
        D_TYPEMASK = 3,
        D_GENDERBASE = 4,
        D_MASCULINE = 4,
        D_FEMININE = 8,
        D_GENDERMASK = 12,
        D_GUFBASE = 16,
        D_FIRST = 16,
        D_SECOND = 32,
        D_THIRD = 48,
        D_GUFMASK = 48,
        D_NUMBASE = 64,
        D_SINGULAR = 64,
        D_DOUBLE = 128,
        D_PLURAL = 192,
        D_NUMMASK = 192,
        D_TENSEBASE = 256,
        D_INFINITIVE = 256,
        D_BINFINITIVE = 1536,
        D_PAST = 512,
        D_PRESENT = 768,
        D_FUTURE = 1024,
        D_IMPERATIVE = 1280,
        D_TENSEMASK = 1792,
        D_OGENDERBASE = 2048,
        D_OMASCULINE = 2048,
        D_OFEMININE = 4096,
        D_OGENDERMASK = 6144,
        D_OGUFBASE = 8192,
        D_OFIRST = 8192,
        D_OSECOND = 16384,
        D_OTHIRD = 24576,
        D_OGUFMASK = 24576,
        D_ONUMBASE = 32768,
        D_OSINGULAR = 32768,
        D_ODOUBLE = 65536,
        D_OPLURAL = 98304,
        D_ONUMMASK = 98304,
        D_OMASK = 129024,
        D_OSMICHUT = 131072,
        D_SPECNOUN = 262144,
        D_STARTBIT = 524288,

        D_ACRONYM = 1048576,

        D_CUSTOM = 1073741824, // word was set by a custom external dictionary
    }

    [Flags]
    public enum PrefixType : byte
    {
        PS_EMPTY = 0,
        PS_B = 1,
        PS_L = 2,
        PS_VERB = 4,
        PS_NONDEF = 8,
        PS_IMPER = 16,
        PS_MISC = 32,
        PS_ALL = 127,
        PS_KL = 64,
    }
}
