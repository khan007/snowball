// This file was generated automatically by the Snowball to C# compiler

#pragma warning disable 0164
#pragma warning disable 0162

namespace Snowball
{
    using System;
    using System.Text;
    
    ///<summary>
    ///  This class was automatically generated by a Snowball to Java compiler 
    ///  It implements the stemming algorithm defined by a snowball script.
    ///</summary>
    /// 
    [System.CodeDom.Compiler.GeneratedCode("Snowball", "0.0.0")]
    public partial class ItalianStemmer : SnowballStemmer
    {
        private int I_p2;
        private int I_p1;
        private int I_pV;

        private static int[] g_v = { 17, 65, 16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 128, 128, 8, 2, 1 };

        private static int[] g_AEIO = { 17, 65, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 128, 128, 8, 2 };

        private static int[] g_CG = { 17 };

        private readonly Among[] a_0;
        private readonly Among[] a_1;
        private readonly Among[] a_2;
        private readonly Among[] a_3;
        private readonly Among[] a_4;
        private readonly Among[] a_5;
        private readonly Among[] a_6;
        private readonly Among[] a_7;

        public ItalianStemmer()
        {
            a_0 = new[] 
            {
                new Among("", -1, 7),
                new Among("qu", 0, 6),
                new Among("\u00C3\u00A1", 0, 1),
                new Among("\u00C3\u00A9", 0, 2),
                new Among("\u00C3\u00AD", 0, 3),
                new Among("\u00C3\u00B3", 0, 4),
                new Among("\u00C3\u00BA", 0, 5)
            };

            a_1 = new[] 
            {
                new Among("", -1, 3),
                new Among("I", 0, 1),
                new Among("U", 0, 2)
            };

            a_2 = new[] 
            {
                new Among("la", -1, -1),
                new Among("cela", 0, -1),
                new Among("gliela", 0, -1),
                new Among("mela", 0, -1),
                new Among("tela", 0, -1),
                new Among("vela", 0, -1),
                new Among("le", -1, -1),
                new Among("cele", 6, -1),
                new Among("gliele", 6, -1),
                new Among("mele", 6, -1),
                new Among("tele", 6, -1),
                new Among("vele", 6, -1),
                new Among("ne", -1, -1),
                new Among("cene", 12, -1),
                new Among("gliene", 12, -1),
                new Among("mene", 12, -1),
                new Among("sene", 12, -1),
                new Among("tene", 12, -1),
                new Among("vene", 12, -1),
                new Among("ci", -1, -1),
                new Among("li", -1, -1),
                new Among("celi", 20, -1),
                new Among("glieli", 20, -1),
                new Among("meli", 20, -1),
                new Among("teli", 20, -1),
                new Among("veli", 20, -1),
                new Among("gli", 20, -1),
                new Among("mi", -1, -1),
                new Among("si", -1, -1),
                new Among("ti", -1, -1),
                new Among("vi", -1, -1),
                new Among("lo", -1, -1),
                new Among("celo", 31, -1),
                new Among("glielo", 31, -1),
                new Among("melo", 31, -1),
                new Among("telo", 31, -1),
                new Among("velo", 31, -1)
            };

            a_3 = new[] 
            {
                new Among("ando", -1, 1),
                new Among("endo", -1, 1),
                new Among("ar", -1, 2),
                new Among("er", -1, 2),
                new Among("ir", -1, 2)
            };

            a_4 = new[] 
            {
                new Among("ic", -1, -1),
                new Among("abil", -1, -1),
                new Among("os", -1, -1),
                new Among("iv", -1, 1)
            };

            a_5 = new[] 
            {
                new Among("ic", -1, 1),
                new Among("abil", -1, 1),
                new Among("iv", -1, 1)
            };

            a_6 = new[] 
            {
                new Among("ica", -1, 1),
                new Among("logia", -1, 3),
                new Among("osa", -1, 1),
                new Among("ista", -1, 1),
                new Among("iva", -1, 9),
                new Among("anza", -1, 1),
                new Among("enza", -1, 5),
                new Among("ice", -1, 1),
                new Among("atrice", 7, 1),
                new Among("iche", -1, 1),
                new Among("logie", -1, 3),
                new Among("abile", -1, 1),
                new Among("ibile", -1, 1),
                new Among("usione", -1, 4),
                new Among("azione", -1, 2),
                new Among("uzione", -1, 4),
                new Among("atore", -1, 2),
                new Among("ose", -1, 1),
                new Among("ante", -1, 1),
                new Among("mente", -1, 1),
                new Among("amente", 19, 7),
                new Among("iste", -1, 1),
                new Among("ive", -1, 9),
                new Among("anze", -1, 1),
                new Among("enze", -1, 5),
                new Among("ici", -1, 1),
                new Among("atrici", 25, 1),
                new Among("ichi", -1, 1),
                new Among("abili", -1, 1),
                new Among("ibili", -1, 1),
                new Among("ismi", -1, 1),
                new Among("usioni", -1, 4),
                new Among("azioni", -1, 2),
                new Among("uzioni", -1, 4),
                new Among("atori", -1, 2),
                new Among("osi", -1, 1),
                new Among("anti", -1, 1),
                new Among("amenti", -1, 6),
                new Among("imenti", -1, 6),
                new Among("isti", -1, 1),
                new Among("ivi", -1, 9),
                new Among("ico", -1, 1),
                new Among("ismo", -1, 1),
                new Among("oso", -1, 1),
                new Among("amento", -1, 6),
                new Among("imento", -1, 6),
                new Among("ivo", -1, 9),
                new Among("it\u00C3\u00A0", -1, 8),
                new Among("ist\u00C3\u00A0", -1, 1),
                new Among("ist\u00C3\u00A8", -1, 1),
                new Among("ist\u00C3\u00AC", -1, 1)
            };

            a_7 = new[] 
            {
                new Among("isca", -1, 1),
                new Among("enda", -1, 1),
                new Among("ata", -1, 1),
                new Among("ita", -1, 1),
                new Among("uta", -1, 1),
                new Among("ava", -1, 1),
                new Among("eva", -1, 1),
                new Among("iva", -1, 1),
                new Among("erebbe", -1, 1),
                new Among("irebbe", -1, 1),
                new Among("isce", -1, 1),
                new Among("ende", -1, 1),
                new Among("are", -1, 1),
                new Among("ere", -1, 1),
                new Among("ire", -1, 1),
                new Among("asse", -1, 1),
                new Among("ate", -1, 1),
                new Among("avate", 16, 1),
                new Among("evate", 16, 1),
                new Among("ivate", 16, 1),
                new Among("ete", -1, 1),
                new Among("erete", 20, 1),
                new Among("irete", 20, 1),
                new Among("ite", -1, 1),
                new Among("ereste", -1, 1),
                new Among("ireste", -1, 1),
                new Among("ute", -1, 1),
                new Among("erai", -1, 1),
                new Among("irai", -1, 1),
                new Among("isci", -1, 1),
                new Among("endi", -1, 1),
                new Among("erei", -1, 1),
                new Among("irei", -1, 1),
                new Among("assi", -1, 1),
                new Among("ati", -1, 1),
                new Among("iti", -1, 1),
                new Among("eresti", -1, 1),
                new Among("iresti", -1, 1),
                new Among("uti", -1, 1),
                new Among("avi", -1, 1),
                new Among("evi", -1, 1),
                new Among("ivi", -1, 1),
                new Among("isco", -1, 1),
                new Among("ando", -1, 1),
                new Among("endo", -1, 1),
                new Among("Yamo", -1, 1),
                new Among("iamo", -1, 1),
                new Among("avamo", -1, 1),
                new Among("evamo", -1, 1),
                new Among("ivamo", -1, 1),
                new Among("eremo", -1, 1),
                new Among("iremo", -1, 1),
                new Among("assimo", -1, 1),
                new Among("ammo", -1, 1),
                new Among("emmo", -1, 1),
                new Among("eremmo", 54, 1),
                new Among("iremmo", 54, 1),
                new Among("immo", -1, 1),
                new Among("ano", -1, 1),
                new Among("iscano", 58, 1),
                new Among("avano", 58, 1),
                new Among("evano", 58, 1),
                new Among("ivano", 58, 1),
                new Among("eranno", -1, 1),
                new Among("iranno", -1, 1),
                new Among("ono", -1, 1),
                new Among("iscono", 65, 1),
                new Among("arono", 65, 1),
                new Among("erono", 65, 1),
                new Among("irono", 65, 1),
                new Among("erebbero", -1, 1),
                new Among("irebbero", -1, 1),
                new Among("assero", -1, 1),
                new Among("essero", -1, 1),
                new Among("issero", -1, 1),
                new Among("ato", -1, 1),
                new Among("ito", -1, 1),
                new Among("uto", -1, 1),
                new Among("avo", -1, 1),
                new Among("evo", -1, 1),
                new Among("ivo", -1, 1),
                new Among("ar", -1, 1),
                new Among("ir", -1, 1),
                new Among("er\u00C3\u00A0", -1, 1),
                new Among("ir\u00C3\u00A0", -1, 1),
                new Among("er\u00C3\u00B2", -1, 1),
                new Among("ir\u00C3\u00B2", -1, 1)
            };

        }



        private bool r_prelude()
        {
            int among_var;
            int v_1;
            int v_2;
            int v_3;
            int v_4;
            int v_5;

            // (, line 34

            // test, line 35
            v_1 = cursor;

            // repeat, line 35
            while (true)
            {
                v_2 = cursor;

                // (, line 35

                // [, line 36
                bra = cursor;

                // substring, line 36
                among_var = find_among(a_0, 7);
                if (among_var == 0)
                {
                    goto lab0;
                }

                // ], line 36
                ket = cursor;
                switch (among_var) 
                {
                    case 0:
                    case 1:

                        // (, line 37

                        // <-, line 37
                        slice_from("\u00C3\u00A0");
                        break;
                    case 2:

                        // (, line 38

                        // <-, line 38
                        slice_from("\u00C3\u00A8");
                        break;
                    case 3:

                        // (, line 39

                        // <-, line 39
                        slice_from("\u00C3\u00AC");
                        break;
                    case 4:

                        // (, line 40

                        // <-, line 40
                        slice_from("\u00C3\u00B2");
                        break;
                    case 5:

                        // (, line 41

                        // <-, line 41
                        slice_from("\u00C3\u00B9");
                        break;
                    case 6:

                        // (, line 42

                        // <-, line 42
                        slice_from("qU");
                        break;
                    case 7:

                        // (, line 43

                        // next, line 43
                        if (cursor >= limit)
                        {
                            goto lab0;
                        }
                        cursor++;
                        break;
                }
                continue;
            lab0: 
                cursor = v_2;
                break;
            }
            cursor = v_1;

            // repeat, line 46
            while (true)
            {
                v_3 = cursor;
                while (true) 
                {

                    // goto, line 46
                    v_4 = cursor;

                    // (, line 46
                    if (!(in_grouping(g_v, 97, 249)))
                    {
                        goto lab2;
                    }

                    // [, line 47
                    bra = cursor;

                    // or, line 47
                    v_5 = cursor;

                    // (, line 47

                    // literal, line 47
                    if (!(eq_s(1, "u")))
                    {
                        goto lab4;
                    }

                    // ], line 47
                    ket = cursor;
                    if (!(in_grouping(g_v, 97, 249)))
                    {
                        goto lab4;
                    }

                    // <-, line 47
                    slice_from("U");
                    goto lab3;
                lab4: 
                    cursor = v_5;

                    // (, line 48

                    // literal, line 48
                    if (!(eq_s(1, "i")))
                    {
                        goto lab2;
                    }

                    // ], line 48
                    ket = cursor;
                    if (!(in_grouping(g_v, 97, 249)))
                    {
                        goto lab2;
                    }

                    // <-, line 48
                    slice_from("I");
                lab3: 
                    cursor = v_4;
                    break;
                lab2: 
                    cursor = v_4;
                    if (cursor >= limit)
                    {
                        goto lab1;
                    }
                    cursor++;
                }
                continue;
            lab1: 
                cursor = v_3;
                break;
            }

            return true;
        }

        private bool r_mark_regions()
        {
            int v_1;
            int v_2;
            int v_3;
            int v_6;
            int v_8;

            // (, line 52
            I_pV = limit;
            I_p1 = limit;
            I_p2 = limit;

            // do, line 58
            v_1 = cursor;

            // (, line 58

            // or, line 60
            v_2 = cursor;

            // (, line 59
            if (!(in_grouping(g_v, 97, 249)))
            {
                goto lab2;
            }

            // or, line 59
            v_3 = cursor;

            // (, line 59
            if (!(out_grouping(g_v, 97, 249)))
            {
                goto lab4;
            }
            while (true) 
            {

                // gopast, line 59
                if (!(in_grouping(g_v, 97, 249)))
                {
                    goto lab5;
                }
                break;
            lab5: 
                if (cursor >= limit)
                {
                    goto lab4;
                }
                cursor++;
            }
            goto lab3;
        lab4: 
            cursor = v_3;

            // (, line 59
            if (!(in_grouping(g_v, 97, 249)))
            {
                goto lab2;
            }
            while (true) 
            {

                // gopast, line 59
                if (!(out_grouping(g_v, 97, 249)))
                {
                    goto lab6;
                }
                break;
            lab6: 
                if (cursor >= limit)
                {
                    goto lab2;
                }
                cursor++;
            }
        lab3: 
            goto lab1;
        lab2: 
            cursor = v_2;

            // (, line 61
            if (!(out_grouping(g_v, 97, 249)))
            {
                goto lab0;
            }

            // or, line 61
            v_6 = cursor;

            // (, line 61
            if (!(out_grouping(g_v, 97, 249)))
            {
                goto lab8;
            }
            while (true) 
            {

                // gopast, line 61
                if (!(in_grouping(g_v, 97, 249)))
                {
                    goto lab9;
                }
                break;
            lab9: 
                if (cursor >= limit)
                {
                    goto lab8;
                }
                cursor++;
            }
            goto lab7;
        lab8: 
            cursor = v_6;

            // (, line 61
            if (!(in_grouping(g_v, 97, 249)))
            {
                goto lab0;
            }

            // next, line 61
            if (cursor >= limit)
            {
                goto lab0;
            }
            cursor++;
        lab7: 
        lab1: 

            // setmark pV, line 62
            I_pV = cursor;
        lab0: 
            cursor = v_1;

            // do, line 64
            v_8 = cursor;

            // (, line 64
            while (true) 
            {

                // gopast, line 65
                if (!(in_grouping(g_v, 97, 249)))
                {
                    goto lab11;
                }
                break;
            lab11: 
                if (cursor >= limit)
                {
                    goto lab10;
                }
                cursor++;
            }
            while (true) 
            {

                // gopast, line 65
                if (!(out_grouping(g_v, 97, 249)))
                {
                    goto lab12;
                }
                break;
            lab12: 
                if (cursor >= limit)
                {
                    goto lab10;
                }
                cursor++;
            }

            // setmark p1, line 65
            I_p1 = cursor;
            while (true) 
            {

                // gopast, line 66
                if (!(in_grouping(g_v, 97, 249)))
                {
                    goto lab13;
                }
                break;
            lab13: 
                if (cursor >= limit)
                {
                    goto lab10;
                }
                cursor++;
            }
            while (true) 
            {

                // gopast, line 66
                if (!(out_grouping(g_v, 97, 249)))
                {
                    goto lab14;
                }
                break;
            lab14: 
                if (cursor >= limit)
                {
                    goto lab10;
                }
                cursor++;
            }

            // setmark p2, line 66
            I_p2 = cursor;
        lab10: 
            cursor = v_8;

            return true;
        }

        private bool r_postlude()
        {
            int among_var;
            int v_1;

            // repeat, line 70
            while (true)
            {
                v_1 = cursor;

                // (, line 70

                // [, line 72
                bra = cursor;

                // substring, line 72
                among_var = find_among(a_1, 3);
                if (among_var == 0)
                {
                    goto lab0;
                }

                // ], line 72
                ket = cursor;
                switch (among_var) 
                {
                    case 0:
                    case 1:

                        // (, line 73

                        // <-, line 73
                        slice_from("i");
                        break;
                    case 2:

                        // (, line 74

                        // <-, line 74
                        slice_from("u");
                        break;
                    case 3:

                        // (, line 75

                        // next, line 75
                        if (cursor >= limit)
                        {
                            goto lab0;
                        }
                        cursor++;
                        break;
                }
                continue;
            lab0: 
                cursor = v_1;
                break;
            }

            return true;
        }

        private bool r_RV()
        {
            if (!(I_pV <= cursor))
            {
                return false;
            }

            return true;
        }

        private bool r_R1()
        {
            if (!(I_p1 <= cursor))
            {
                return false;
            }

            return true;
        }

        private bool r_R2()
        {
            if (!(I_p2 <= cursor))
            {
                return false;
            }

            return true;
        }

        private bool r_attached_pronoun()
        {
            int among_var;

            // (, line 86

            // [, line 87
            ket = cursor;

            // substring, line 87
            if (find_among_b(a_2, 37) == 0)
            {
                return false;
            }

            // ], line 87
            bra = cursor;

            // among, line 97
            among_var = find_among_b(a_3, 5);
            if (among_var == 0)
            {
                return false;
            }

            // (, line 97

            // call RV, line 97
            if (!r_RV())
            {
                return false;
            }
            switch (among_var) 
            {
                case 0:
                case 1:

                    // (, line 98

                    // delete, line 98
                    slice_del();
                    break;
                case 2:

                    // (, line 99

                    // <-, line 99
                    slice_from("e");
                    break;
            }

            return true;
        }

        private bool r_standard_suffix()
        {
            int among_var;
            int v_1;
            int v_2;
            int v_3;
            int v_4;

            // (, line 103

            // [, line 104
            ket = cursor;

            // substring, line 104
            among_var = find_among_b(a_6, 51);
            if (among_var == 0)
            {
                return false;
            }

            // ], line 104
            bra = cursor;
            switch (among_var) 
            {
                case 0:
                case 1:

                    // (, line 111

                    // call R2, line 111
                    if (!r_R2())
                    {
                        return false;
                    }

                    // delete, line 111
                    slice_del();
                    break;
                case 2:

                    // (, line 113

                    // call R2, line 113
                    if (!r_R2())
                    {
                        return false;
                    }

                    // delete, line 113
                    slice_del();

                    // try, line 114
                    v_1 = limit - cursor;

                    // (, line 114

                    // [, line 114
                    ket = cursor;

                    // literal, line 114
                    if (!(eq_s_b(2, "ic")))
                    {
                        cursor = limit - v_1;
                        goto lab0;
                    }

                    // ], line 114
                    bra = cursor;

                    // call R2, line 114
                    if (!r_R2())
                    {
                        cursor = limit - v_1;
                        goto lab0;
                    }

                    // delete, line 114
                    slice_del();
                lab0: 
                    break;
                case 3:

                    // (, line 117

                    // call R2, line 117
                    if (!r_R2())
                    {
                        return false;
                    }

                    // <-, line 117
                    slice_from("log");
                    break;
                case 4:

                    // (, line 119

                    // call R2, line 119
                    if (!r_R2())
                    {
                        return false;
                    }

                    // <-, line 119
                    slice_from("u");
                    break;
                case 5:

                    // (, line 121

                    // call R2, line 121
                    if (!r_R2())
                    {
                        return false;
                    }

                    // <-, line 121
                    slice_from("ente");
                    break;
                case 6:

                    // (, line 123

                    // call RV, line 123
                    if (!r_RV())
                    {
                        return false;
                    }

                    // delete, line 123
                    slice_del();
                    break;
                case 7:

                    // (, line 124

                    // call R1, line 125
                    if (!r_R1())
                    {
                        return false;
                    }

                    // delete, line 125
                    slice_del();

                    // try, line 126
                    v_2 = limit - cursor;

                    // (, line 126

                    // [, line 127
                    ket = cursor;

                    // substring, line 127
                    among_var = find_among_b(a_4, 4);
                    if (among_var == 0)
                    {
                        cursor = limit - v_2;
                        goto lab1;
                    }

                    // ], line 127
                    bra = cursor;

                    // call R2, line 127
                    if (!r_R2())
                    {
                        cursor = limit - v_2;
                        goto lab1;
                    }

                    // delete, line 127
                    slice_del();
                    switch (among_var) 
                    {
                        case 0:
                        case 1:

                            // (, line 128

                            // [, line 128
                            ket = cursor;

                            // literal, line 128
                            if (!(eq_s_b(2, "at")))
                            {
                                cursor = limit - v_2;
                                goto lab1;
                            }

                            // ], line 128
                            bra = cursor;

                            // call R2, line 128
                            if (!r_R2())
                            {
                                cursor = limit - v_2;
                                goto lab1;
                            }

                            // delete, line 128
                            slice_del();
                            break;
                    }
                lab1: 
                    break;
                case 8:

                    // (, line 133

                    // call R2, line 134
                    if (!r_R2())
                    {
                        return false;
                    }

                    // delete, line 134
                    slice_del();

                    // try, line 135
                    v_3 = limit - cursor;

                    // (, line 135

                    // [, line 136
                    ket = cursor;

                    // substring, line 136
                    among_var = find_among_b(a_5, 3);
                    if (among_var == 0)
                    {
                        cursor = limit - v_3;
                        goto lab2;
                    }

                    // ], line 136
                    bra = cursor;
                    switch (among_var) 
                    {
                        case 0:
                        case 1:

                            // (, line 137

                            // call R2, line 137
                            if (!r_R2())
                            {
                                cursor = limit - v_3;
                                goto lab2;
                            }

                            // delete, line 137
                            slice_del();
                            break;
                    }
                lab2: 
                    break;
                case 9:

                    // (, line 141

                    // call R2, line 142
                    if (!r_R2())
                    {
                        return false;
                    }

                    // delete, line 142
                    slice_del();

                    // try, line 143
                    v_4 = limit - cursor;

                    // (, line 143

                    // [, line 143
                    ket = cursor;

                    // literal, line 143
                    if (!(eq_s_b(2, "at")))
                    {
                        cursor = limit - v_4;
                        goto lab3;
                    }

                    // ], line 143
                    bra = cursor;

                    // call R2, line 143
                    if (!r_R2())
                    {
                        cursor = limit - v_4;
                        goto lab3;
                    }

                    // delete, line 143
                    slice_del();

                    // [, line 143
                    ket = cursor;

                    // literal, line 143
                    if (!(eq_s_b(2, "ic")))
                    {
                        cursor = limit - v_4;
                        goto lab3;
                    }

                    // ], line 143
                    bra = cursor;

                    // call R2, line 143
                    if (!r_R2())
                    {
                        cursor = limit - v_4;
                        goto lab3;
                    }

                    // delete, line 143
                    slice_del();
                lab3: 
                    break;
            }

            return true;
        }

        private bool r_verb_suffix()
        {
            int among_var;
            int v_1;
            int v_2;

            // setlimit, line 148
            v_1 = limit - cursor;

            // tomark, line 148
            if (cursor < I_pV)
            {
                return false;
            }
            cursor = I_pV;
            v_2 = limit_backward;
            limit_backward = cursor;
            cursor = limit - v_1;

            // (, line 148

            // [, line 149
            ket = cursor;

            // substring, line 149
            among_var = find_among_b(a_7, 87);
            if (among_var == 0)
            {
                limit_backward = v_2;
                return false;
            }

            // ], line 149
            bra = cursor;
            switch (among_var) 
            {
                case 0:
                case 1:

                    // (, line 163

                    // delete, line 163
                    slice_del();
                    break;
            }
            limit_backward = v_2;

            return true;
        }

        private bool r_vowel_suffix()
        {
            int v_1;
            int v_2;

            // (, line 170

            // try, line 171
            v_1 = limit - cursor;

            // (, line 171

            // [, line 172
            ket = cursor;
            if (!(in_grouping_b(g_AEIO, 97, 242)))
            {
                cursor = limit - v_1;
                goto lab0;
            }

            // ], line 172
            bra = cursor;

            // call RV, line 172
            if (!r_RV())
            {
                cursor = limit - v_1;
                goto lab0;
            }

            // delete, line 172
            slice_del();

            // [, line 173
            ket = cursor;

            // literal, line 173
            if (!(eq_s_b(1, "i")))
            {
                cursor = limit - v_1;
                goto lab0;
            }

            // ], line 173
            bra = cursor;

            // call RV, line 173
            if (!r_RV())
            {
                cursor = limit - v_1;
                goto lab0;
            }

            // delete, line 173
            slice_del();
        lab0: 

            // try, line 175
            v_2 = limit - cursor;

            // (, line 175

            // [, line 176
            ket = cursor;

            // literal, line 176
            if (!(eq_s_b(1, "h")))
            {
                cursor = limit - v_2;
                goto lab1;
            }

            // ], line 176
            bra = cursor;
            if (!(in_grouping_b(g_CG, 99, 103)))
            {
                cursor = limit - v_2;
                goto lab1;
            }

            // call RV, line 176
            if (!r_RV())
            {
                cursor = limit - v_2;
                goto lab1;
            }

            // delete, line 176
            slice_del();
        lab1: 

            return true;
        }

        private bool stem()
        {
            int v_1;
            int v_2;
            int v_3;
            int v_4;
            int v_5;
            int v_6;
            int v_7;

            // (, line 181

            // do, line 182
            v_1 = cursor;

            // call prelude, line 182
            if (!r_prelude())
            {
                goto lab0;
            }
        lab0: 
            cursor = v_1;

            // do, line 183
            v_2 = cursor;

            // call mark_regions, line 183
            if (!r_mark_regions())
            {
                goto lab1;
            }
        lab1: 
            cursor = v_2;

            // backwards, line 184
            limit_backward = cursor; cursor = limit;

            // (, line 184

            // do, line 185
            v_3 = limit - cursor;

            // call attached_pronoun, line 185
            if (!r_attached_pronoun())
            {
                goto lab2;
            }
        lab2: 
            cursor = limit - v_3;

            // do, line 186
            v_4 = limit - cursor;

            // (, line 186

            // or, line 186
            v_5 = limit - cursor;

            // call standard_suffix, line 186
            if (!r_standard_suffix())
            {
                goto lab5;
            }
            goto lab4;
        lab5: 
            cursor = limit - v_5;

            // call verb_suffix, line 186
            if (!r_verb_suffix())
            {
                goto lab3;
            }
        lab4: 
        lab3: 
            cursor = limit - v_4;

            // do, line 187
            v_6 = limit - cursor;

            // call vowel_suffix, line 187
            if (!r_vowel_suffix())
            {
                goto lab6;
            }
        lab6: 
            cursor = limit - v_6;
            cursor = limit_backward;

            // do, line 189
            v_7 = cursor;

            // call postlude, line 189
            if (!r_postlude())
            {
                goto lab7;
            }
        lab7: 
            cursor = v_7;

            return true;
        }

        protected override bool Process()
        {
            return this.stem();
        }

    }
}
