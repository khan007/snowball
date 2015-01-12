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
    public partial class PortugueseStemmer : SnowballStemmer
    {
        private int I_p2;
        private int I_p1;
        private int I_pV;

        private static int[] g_v = { 17, 65, 16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 19, 12, 2 };

        private readonly Among[] a_0;
        private readonly Among[] a_1;
        private readonly Among[] a_2;
        private readonly Among[] a_3;
        private readonly Among[] a_4;
        private readonly Among[] a_5;
        private readonly Among[] a_6;
        private readonly Among[] a_7;
        private readonly Among[] a_8;

        public PortugueseStemmer()
        {
            a_0 = new[] 
            {
                new Among(UTF16(""), -1, 3),
                new Among(UTF16("\u00C3\u00A3"), 0, 1),
                new Among(UTF16("\u00C3\u00B5"), 0, 2)
            };

            a_1 = new[] 
            {
                new Among(UTF16(""), -1, 3),
                new Among(UTF16("a~"), 0, 1),
                new Among(UTF16("o~"), 0, 2)
            };

            a_2 = new[] 
            {
                new Among(UTF16("ic"), -1, -1),
                new Among(UTF16("ad"), -1, -1),
                new Among(UTF16("os"), -1, -1),
                new Among(UTF16("iv"), -1, 1)
            };

            a_3 = new[] 
            {
                new Among(UTF16("ante"), -1, 1),
                new Among(UTF16("avel"), -1, 1),
                new Among(UTF16("\u00C3\u00ADvel"), -1, 1)
            };

            a_4 = new[] 
            {
                new Among(UTF16("ic"), -1, 1),
                new Among(UTF16("abil"), -1, 1),
                new Among(UTF16("iv"), -1, 1)
            };

            a_5 = new[] 
            {
                new Among(UTF16("ica"), -1, 1),
                new Among(UTF16("\u00C3\u00A2ncia"), -1, 1),
                new Among(UTF16("\u00C3\u00AAncia"), -1, 4),
                new Among(UTF16("ira"), -1, 9),
                new Among(UTF16("adora"), -1, 1),
                new Among(UTF16("osa"), -1, 1),
                new Among(UTF16("ista"), -1, 1),
                new Among(UTF16("iva"), -1, 8),
                new Among(UTF16("eza"), -1, 1),
                new Among(UTF16("log\u00C3\u00ADa"), -1, 2),
                new Among(UTF16("idade"), -1, 7),
                new Among(UTF16("ante"), -1, 1),
                new Among(UTF16("mente"), -1, 6),
                new Among(UTF16("amente"), 12, 5),
                new Among(UTF16("\u00C3\u00A1vel"), -1, 1),
                new Among(UTF16("\u00C3\u00ADvel"), -1, 1),
                new Among(UTF16("uci\u00C3\u00B3n"), -1, 3),
                new Among(UTF16("ico"), -1, 1),
                new Among(UTF16("ismo"), -1, 1),
                new Among(UTF16("oso"), -1, 1),
                new Among(UTF16("amento"), -1, 1),
                new Among(UTF16("imento"), -1, 1),
                new Among(UTF16("ivo"), -1, 8),
                new Among(UTF16("a\u00C3\u00A7a~o"), -1, 1),
                new Among(UTF16("ador"), -1, 1),
                new Among(UTF16("icas"), -1, 1),
                new Among(UTF16("\u00C3\u00AAncias"), -1, 4),
                new Among(UTF16("iras"), -1, 9),
                new Among(UTF16("adoras"), -1, 1),
                new Among(UTF16("osas"), -1, 1),
                new Among(UTF16("istas"), -1, 1),
                new Among(UTF16("ivas"), -1, 8),
                new Among(UTF16("ezas"), -1, 1),
                new Among(UTF16("log\u00C3\u00ADas"), -1, 2),
                new Among(UTF16("idades"), -1, 7),
                new Among(UTF16("uciones"), -1, 3),
                new Among(UTF16("adores"), -1, 1),
                new Among(UTF16("antes"), -1, 1),
                new Among(UTF16("a\u00C3\u00A7o~es"), -1, 1),
                new Among(UTF16("icos"), -1, 1),
                new Among(UTF16("ismos"), -1, 1),
                new Among(UTF16("osos"), -1, 1),
                new Among(UTF16("amentos"), -1, 1),
                new Among(UTF16("imentos"), -1, 1),
                new Among(UTF16("ivos"), -1, 8)
            };

            a_6 = new[] 
            {
                new Among(UTF16("ada"), -1, 1),
                new Among(UTF16("ida"), -1, 1),
                new Among(UTF16("ia"), -1, 1),
                new Among(UTF16("aria"), 2, 1),
                new Among(UTF16("eria"), 2, 1),
                new Among(UTF16("iria"), 2, 1),
                new Among(UTF16("ara"), -1, 1),
                new Among(UTF16("era"), -1, 1),
                new Among(UTF16("ira"), -1, 1),
                new Among(UTF16("ava"), -1, 1),
                new Among(UTF16("asse"), -1, 1),
                new Among(UTF16("esse"), -1, 1),
                new Among(UTF16("isse"), -1, 1),
                new Among(UTF16("aste"), -1, 1),
                new Among(UTF16("este"), -1, 1),
                new Among(UTF16("iste"), -1, 1),
                new Among(UTF16("ei"), -1, 1),
                new Among(UTF16("arei"), 16, 1),
                new Among(UTF16("erei"), 16, 1),
                new Among(UTF16("irei"), 16, 1),
                new Among(UTF16("am"), -1, 1),
                new Among(UTF16("iam"), 20, 1),
                new Among(UTF16("ariam"), 21, 1),
                new Among(UTF16("eriam"), 21, 1),
                new Among(UTF16("iriam"), 21, 1),
                new Among(UTF16("aram"), 20, 1),
                new Among(UTF16("eram"), 20, 1),
                new Among(UTF16("iram"), 20, 1),
                new Among(UTF16("avam"), 20, 1),
                new Among(UTF16("em"), -1, 1),
                new Among(UTF16("arem"), 29, 1),
                new Among(UTF16("erem"), 29, 1),
                new Among(UTF16("irem"), 29, 1),
                new Among(UTF16("assem"), 29, 1),
                new Among(UTF16("essem"), 29, 1),
                new Among(UTF16("issem"), 29, 1),
                new Among(UTF16("ado"), -1, 1),
                new Among(UTF16("ido"), -1, 1),
                new Among(UTF16("ando"), -1, 1),
                new Among(UTF16("endo"), -1, 1),
                new Among(UTF16("indo"), -1, 1),
                new Among(UTF16("ara~o"), -1, 1),
                new Among(UTF16("era~o"), -1, 1),
                new Among(UTF16("ira~o"), -1, 1),
                new Among(UTF16("ar"), -1, 1),
                new Among(UTF16("er"), -1, 1),
                new Among(UTF16("ir"), -1, 1),
                new Among(UTF16("as"), -1, 1),
                new Among(UTF16("adas"), 47, 1),
                new Among(UTF16("idas"), 47, 1),
                new Among(UTF16("ias"), 47, 1),
                new Among(UTF16("arias"), 50, 1),
                new Among(UTF16("erias"), 50, 1),
                new Among(UTF16("irias"), 50, 1),
                new Among(UTF16("aras"), 47, 1),
                new Among(UTF16("eras"), 47, 1),
                new Among(UTF16("iras"), 47, 1),
                new Among(UTF16("avas"), 47, 1),
                new Among(UTF16("es"), -1, 1),
                new Among(UTF16("ardes"), 58, 1),
                new Among(UTF16("erdes"), 58, 1),
                new Among(UTF16("irdes"), 58, 1),
                new Among(UTF16("ares"), 58, 1),
                new Among(UTF16("eres"), 58, 1),
                new Among(UTF16("ires"), 58, 1),
                new Among(UTF16("asses"), 58, 1),
                new Among(UTF16("esses"), 58, 1),
                new Among(UTF16("isses"), 58, 1),
                new Among(UTF16("astes"), 58, 1),
                new Among(UTF16("estes"), 58, 1),
                new Among(UTF16("istes"), 58, 1),
                new Among(UTF16("is"), -1, 1),
                new Among(UTF16("ais"), 71, 1),
                new Among(UTF16("eis"), 71, 1),
                new Among(UTF16("areis"), 73, 1),
                new Among(UTF16("ereis"), 73, 1),
                new Among(UTF16("ireis"), 73, 1),
                new Among(UTF16("\u00C3\u00A1reis"), 73, 1),
                new Among(UTF16("\u00C3\u00A9reis"), 73, 1),
                new Among(UTF16("\u00C3\u00ADreis"), 73, 1),
                new Among(UTF16("\u00C3\u00A1sseis"), 73, 1),
                new Among(UTF16("\u00C3\u00A9sseis"), 73, 1),
                new Among(UTF16("\u00C3\u00ADsseis"), 73, 1),
                new Among(UTF16("\u00C3\u00A1veis"), 73, 1),
                new Among(UTF16("\u00C3\u00ADeis"), 73, 1),
                new Among(UTF16("ar\u00C3\u00ADeis"), 84, 1),
                new Among(UTF16("er\u00C3\u00ADeis"), 84, 1),
                new Among(UTF16("ir\u00C3\u00ADeis"), 84, 1),
                new Among(UTF16("ados"), -1, 1),
                new Among(UTF16("idos"), -1, 1),
                new Among(UTF16("amos"), -1, 1),
                new Among(UTF16("\u00C3\u00A1ramos"), 90, 1),
                new Among(UTF16("\u00C3\u00A9ramos"), 90, 1),
                new Among(UTF16("\u00C3\u00ADramos"), 90, 1),
                new Among(UTF16("\u00C3\u00A1vamos"), 90, 1),
                new Among(UTF16("\u00C3\u00ADamos"), 90, 1),
                new Among(UTF16("ar\u00C3\u00ADamos"), 95, 1),
                new Among(UTF16("er\u00C3\u00ADamos"), 95, 1),
                new Among(UTF16("ir\u00C3\u00ADamos"), 95, 1),
                new Among(UTF16("emos"), -1, 1),
                new Among(UTF16("aremos"), 99, 1),
                new Among(UTF16("eremos"), 99, 1),
                new Among(UTF16("iremos"), 99, 1),
                new Among(UTF16("\u00C3\u00A1ssemos"), 99, 1),
                new Among(UTF16("\u00C3\u00AAssemos"), 99, 1),
                new Among(UTF16("\u00C3\u00ADssemos"), 99, 1),
                new Among(UTF16("imos"), -1, 1),
                new Among(UTF16("armos"), -1, 1),
                new Among(UTF16("ermos"), -1, 1),
                new Among(UTF16("irmos"), -1, 1),
                new Among(UTF16("\u00C3\u00A1mos"), -1, 1),
                new Among(UTF16("ar\u00C3\u00A1s"), -1, 1),
                new Among(UTF16("er\u00C3\u00A1s"), -1, 1),
                new Among(UTF16("ir\u00C3\u00A1s"), -1, 1),
                new Among(UTF16("eu"), -1, 1),
                new Among(UTF16("iu"), -1, 1),
                new Among(UTF16("ou"), -1, 1),
                new Among(UTF16("ar\u00C3\u00A1"), -1, 1),
                new Among(UTF16("er\u00C3\u00A1"), -1, 1),
                new Among(UTF16("ir\u00C3\u00A1"), -1, 1)
            };

            a_7 = new[] 
            {
                new Among(UTF16("a"), -1, 1),
                new Among(UTF16("i"), -1, 1),
                new Among(UTF16("o"), -1, 1),
                new Among(UTF16("os"), -1, 1),
                new Among(UTF16("\u00C3\u00A1"), -1, 1),
                new Among(UTF16("\u00C3\u00AD"), -1, 1),
                new Among(UTF16("\u00C3\u00B3"), -1, 1)
            };

            a_8 = new[] 
            {
                new Among(UTF16("e"), -1, 1),
                new Among(UTF16("\u00C3\u00A7"), -1, 2),
                new Among(UTF16("\u00C3\u00A9"), -1, 1),
                new Among(UTF16("\u00C3\u00AA"), -1, 1)
            };

        }



        private bool r_prelude()
        {
            int among_var;
            int v_1;
            // repeat, line 36
            while (true)
            {
                v_1 = cursor;
                // (, line 36
                // [, line 37
                bra = cursor;
                // substring, line 37
                among_var = find_among(a_0);
                if (among_var == 0)
                {
                    goto lab0;
                }
                // ], line 37
                ket = cursor;
                switch (among_var) 
                {
                    case 0:
                        break;
                    case 1:
                        // (, line 38
                        // <-, line 38
                        slice_from(UTF16("a~"));
                        break;
                    case 2:
                        // (, line 39
                        // <-, line 39
                        slice_from(UTF16("o~"));
                        break;
                    case 3:
                        // (, line 40
                        // next, line 40
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

        private bool r_mark_regions()
        {
            int v_1;
            int v_2;
            int v_3;
            int v_6;
            int v_8;
            // (, line 44
            I_pV = limit;
            I_p1 = limit;
            I_p2 = limit;
            // do, line 50
            v_1 = cursor;
            // (, line 50
            // or, line 52
            v_2 = cursor;
            // (, line 51
            if (!(in_grouping(g_v, 97, 250)))
            {
                goto lab2;
            }
            // or, line 51
            v_3 = cursor;
            // (, line 51
            if (!(out_grouping(g_v, 97, 250)))
            {
                goto lab4;
            }
            while (true) 
            {
                // gopast, line 51
                if (!(in_grouping(g_v, 97, 250)))
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
            // (, line 51
            if (!(in_grouping(g_v, 97, 250)))
            {
                goto lab2;
            }
            while (true) 
            {
                // gopast, line 51
                if (!(out_grouping(g_v, 97, 250)))
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
            // (, line 53
            if (!(out_grouping(g_v, 97, 250)))
            {
                goto lab0;
            }
            // or, line 53
            v_6 = cursor;
            // (, line 53
            if (!(out_grouping(g_v, 97, 250)))
            {
                goto lab8;
            }
            while (true) 
            {
                // gopast, line 53
                if (!(in_grouping(g_v, 97, 250)))
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
            // (, line 53
            if (!(in_grouping(g_v, 97, 250)))
            {
                goto lab0;
            }
            // next, line 53
            if (cursor >= limit)
            {
                goto lab0;
            }
            cursor++;
        lab7: 
        lab1: 
            // setmark pV, line 54
            I_pV = cursor;
        lab0: 
            cursor = v_1;
            // do, line 56
            v_8 = cursor;
            // (, line 56
            while (true) 
            {
                // gopast, line 57
                if (!(in_grouping(g_v, 97, 250)))
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
                // gopast, line 57
                if (!(out_grouping(g_v, 97, 250)))
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
            // setmark p1, line 57
            I_p1 = cursor;
            while (true) 
            {
                // gopast, line 58
                if (!(in_grouping(g_v, 97, 250)))
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
                // gopast, line 58
                if (!(out_grouping(g_v, 97, 250)))
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
            // setmark p2, line 58
            I_p2 = cursor;
        lab10: 
            cursor = v_8;

            return true;
        }

        private bool r_postlude()
        {
            int among_var;
            int v_1;
            // repeat, line 62
            while (true)
            {
                v_1 = cursor;
                // (, line 62
                // [, line 63
                bra = cursor;
                // substring, line 63
                among_var = find_among(a_1);
                if (among_var == 0)
                {
                    goto lab0;
                }
                // ], line 63
                ket = cursor;
                switch (among_var) 
                {
                    case 0:
                        break;
                    case 1:
                        // (, line 64
                        // <-, line 64
                        slice_from(UTF16("\u00C3\u00A3"));
                        break;
                    case 2:
                        // (, line 65
                        // <-, line 65
                        slice_from(UTF16("\u00C3\u00B5"));
                        break;
                    case 3:
                        // (, line 66
                        // next, line 66
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

        private bool r_standard_suffix()
        {
            int among_var;
            int v_1;
            int v_2;
            int v_3;
            int v_4;
            // (, line 76
            // [, line 77
            ket = cursor;
            // substring, line 77
            among_var = find_among_b(a_5);
            if (among_var == 0)
            {
                return false;
            }
            // ], line 77
            bra = cursor;
            switch (among_var) 
            {
                case 0:
                    break;
                case 1:
                    // (, line 92
                    // call R2, line 93
                    if (!r_R2())
                    {
                        return false;
                    }
                    // delete, line 93
                    slice_del();
                    break;
                case 2:
                    // (, line 97
                    // call R2, line 98
                    if (!r_R2())
                    {
                        return false;
                    }
                    // <-, line 98
                    slice_from(UTF16("log"));
                    break;
                case 3:
                    // (, line 101
                    // call R2, line 102
                    if (!r_R2())
                    {
                        return false;
                    }
                    // <-, line 102
                    slice_from(UTF16("u"));
                    break;
                case 4:
                    // (, line 105
                    // call R2, line 106
                    if (!r_R2())
                    {
                        return false;
                    }
                    // <-, line 106
                    slice_from(UTF16("ente"));
                    break;
                case 5:
                    // (, line 109
                    // call R1, line 110
                    if (!r_R1())
                    {
                        return false;
                    }
                    // delete, line 110
                    slice_del();
                    // try, line 111
                    v_1 = limit - cursor;
                    // (, line 111
                    // [, line 112
                    ket = cursor;
                    // substring, line 112
                    among_var = find_among_b(a_2);
                    if (among_var == 0)
                    {
                        cursor = limit - v_1;
                        goto lab0;
                    }
                    // ], line 112
                    bra = cursor;
                    // call R2, line 112
                    if (!r_R2())
                    {
                        cursor = limit - v_1;
                        goto lab0;
                    }
                    // delete, line 112
                    slice_del();
                    switch (among_var) 
                    {
                        case 0:
                            break;
                        case 1:
                            // (, line 113
                            // [, line 113
                            ket = cursor;
                            // literal, line 113
                            if (!(eq_s_b(UTF16("at"))))
                            {
                                cursor = limit - v_1;
                                goto lab0;
                            }
                            // ], line 113
                            bra = cursor;
                            // call R2, line 113
                            if (!r_R2())
                            {
                                cursor = limit - v_1;
                                goto lab0;
                            }
                            // delete, line 113
                            slice_del();
                            break;
                    }
                lab0: 
                    break;
                case 6:
                    // (, line 121
                    // call R2, line 122
                    if (!r_R2())
                    {
                        return false;
                    }
                    // delete, line 122
                    slice_del();
                    // try, line 123
                    v_2 = limit - cursor;
                    // (, line 123
                    // [, line 124
                    ket = cursor;
                    // substring, line 124
                    among_var = find_among_b(a_3);
                    if (among_var == 0)
                    {
                        cursor = limit - v_2;
                        goto lab1;
                    }
                    // ], line 124
                    bra = cursor;
                    switch (among_var) 
                    {
                        case 0:
                            break;
                        case 1:
                            // (, line 127
                            // call R2, line 127
                            if (!r_R2())
                            {
                                cursor = limit - v_2;
                                goto lab1;
                            }
                            // delete, line 127
                            slice_del();
                            break;
                    }
                lab1: 
                    break;
                case 7:
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
                    among_var = find_among_b(a_4);
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
                            break;
                        case 1:
                            // (, line 139
                            // call R2, line 139
                            if (!r_R2())
                            {
                                cursor = limit - v_3;
                                goto lab2;
                            }
                            // delete, line 139
                            slice_del();
                            break;
                    }
                lab2: 
                    break;
                case 8:
                    // (, line 145
                    // call R2, line 146
                    if (!r_R2())
                    {
                        return false;
                    }
                    // delete, line 146
                    slice_del();
                    // try, line 147
                    v_4 = limit - cursor;
                    // (, line 147
                    // [, line 148
                    ket = cursor;
                    // literal, line 148
                    if (!(eq_s_b(UTF16("at"))))
                    {
                        cursor = limit - v_4;
                        goto lab3;
                    }
                    // ], line 148
                    bra = cursor;
                    // call R2, line 148
                    if (!r_R2())
                    {
                        cursor = limit - v_4;
                        goto lab3;
                    }
                    // delete, line 148
                    slice_del();
                lab3: 
                    break;
                case 9:
                    // (, line 152
                    // call RV, line 153
                    if (!r_RV())
                    {
                        return false;
                    }
                    // literal, line 153
                    if (!(eq_s_b(UTF16("e"))))
                    {
                        return false;
                    }
                    // <-, line 154
                    slice_from(UTF16("ir"));
                    break;
            }

            return true;
        }

        private bool r_verb_suffix()
        {
            int among_var;
            int v_1;
            int v_2;
            // setlimit, line 159
            v_1 = limit - cursor;
            // tomark, line 159
            if (cursor < I_pV)
            {
                return false;
            }
            cursor = I_pV;
            v_2 = limit_backward;
            limit_backward = cursor;
            cursor = limit - v_1;
            // (, line 159
            // [, line 160
            ket = cursor;
            // substring, line 160
            among_var = find_among_b(a_6);
            if (among_var == 0)
            {
                limit_backward = v_2;
                return false;
            }
            // ], line 160
            bra = cursor;
            switch (among_var) 
            {
                case 0:
                    break;
                case 1:
                    // (, line 179
                    // delete, line 179
                    slice_del();
                    break;
            }
            limit_backward = v_2;

            return true;
        }

        private bool r_residual_suffix()
        {
            int among_var;
            // (, line 183
            // [, line 184
            ket = cursor;
            // substring, line 184
            among_var = find_among_b(a_7);
            if (among_var == 0)
            {
                return false;
            }
            // ], line 184
            bra = cursor;
            switch (among_var) 
            {
                case 0:
                    break;
                case 1:
                    // (, line 187
                    // call RV, line 187
                    if (!r_RV())
                    {
                        return false;
                    }
                    // delete, line 187
                    slice_del();
                    break;
            }

            return true;
        }

        private bool r_residual_form()
        {
            int among_var;
            int v_1;
            int v_2;
            int v_3;
            // (, line 191
            // [, line 192
            ket = cursor;
            // substring, line 192
            among_var = find_among_b(a_8);
            if (among_var == 0)
            {
                return false;
            }
            // ], line 192
            bra = cursor;
            switch (among_var) 
            {
                case 0:
                    break;
                case 1:
                    // (, line 194
                    // call RV, line 194
                    if (!r_RV())
                    {
                        return false;
                    }
                    // delete, line 194
                    slice_del();
                    // [, line 194
                    ket = cursor;
                    // or, line 194
                    v_1 = limit - cursor;
                    // (, line 194
                    // literal, line 194
                    if (!(eq_s_b(UTF16("u"))))
                    {
                        goto lab1;
                    }
                    // ], line 194
                    bra = cursor;
                    // test, line 194
                    v_2 = limit - cursor;
                    // literal, line 194
                    if (!(eq_s_b(UTF16("g"))))
                    {
                        goto lab1;
                    }
                    cursor = limit - v_2;
                    goto lab0;
                lab1: 
                    cursor = limit - v_1;
                    // (, line 195
                    // literal, line 195
                    if (!(eq_s_b(UTF16("i"))))
                    {
                        return false;
                    }
                    // ], line 195
                    bra = cursor;
                    // test, line 195
                    v_3 = limit - cursor;
                    // literal, line 195
                    if (!(eq_s_b(UTF16("c"))))
                    {
                        return false;
                    }
                    cursor = limit - v_3;
                lab0: 
                    // call RV, line 195
                    if (!r_RV())
                    {
                        return false;
                    }
                    // delete, line 195
                    slice_del();
                    break;
                case 2:
                    // (, line 196
                    // <-, line 196
                    slice_from(UTF16("c"));
                    break;
            }

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
            int v_8;
            int v_9;
            int v_10;
            // (, line 201
            // do, line 202
            v_1 = cursor;
            // call prelude, line 202
            if (!r_prelude())
            {
                goto lab0;
            }
        lab0: 
            cursor = v_1;
            // do, line 203
            v_2 = cursor;
            // call mark_regions, line 203
            if (!r_mark_regions())
            {
                goto lab1;
            }
        lab1: 
            cursor = v_2;
            // backwards, line 204
            limit_backward = cursor; cursor = limit;
            // (, line 204
            // do, line 205
            v_3 = limit - cursor;
            // (, line 205
            // or, line 209
            v_4 = limit - cursor;
            // (, line 206
            // and, line 207
            v_5 = limit - cursor;
            // (, line 206
            // or, line 206
            v_6 = limit - cursor;
            // call standard_suffix, line 206
            if (!r_standard_suffix())
            {
                goto lab6;
            }
            goto lab5;
        lab6: 
            cursor = limit - v_6;
            // call verb_suffix, line 206
            if (!r_verb_suffix())
            {
                goto lab4;
            }
        lab5: 
            cursor = limit - v_5;
            // do, line 207
            v_7 = limit - cursor;
            // (, line 207
            // [, line 207
            ket = cursor;
            // literal, line 207
            if (!(eq_s_b(UTF16("i"))))
            {
                goto lab7;
            }
            // ], line 207
            bra = cursor;
            // test, line 207
            v_8 = limit - cursor;
            // literal, line 207
            if (!(eq_s_b(UTF16("c"))))
            {
                goto lab7;
            }
            cursor = limit - v_8;
            // call RV, line 207
            if (!r_RV())
            {
                goto lab7;
            }
            // delete, line 207
            slice_del();
        lab7: 
            cursor = limit - v_7;
            goto lab3;
        lab4: 
            cursor = limit - v_4;
            // call residual_suffix, line 209
            if (!r_residual_suffix())
            {
                goto lab2;
            }
        lab3: 
        lab2: 
            cursor = limit - v_3;
            // do, line 211
            v_9 = limit - cursor;
            // call residual_form, line 211
            if (!r_residual_form())
            {
                goto lab8;
            }
        lab8: 
            cursor = limit - v_9;
            cursor = limit_backward;
            // do, line 213
            v_10 = cursor;
            // call postlude, line 213
            if (!r_postlude())
            {
                goto lab9;
            }
        lab9: 
            cursor = v_10;

            return true;
        }

        protected override bool Process()
        {
            return this.stem();
        }

    }
}

