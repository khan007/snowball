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
    public partial class FinnishStemmer : SnowballStemmer
    {
        private bool B_ending_removed;
        private StringBuilder S_x = new StringBuilder();
        private int I_p2;
        private int I_p1;

        private static int[] g_AEI = { 17, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8 };

        private static int[] g_V1 = { 17, 65, 16, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 0, 32 };

        private static int[] g_V2 = { 17, 65, 16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 0, 32 };

        private static int[] g_particle_end = { 17, 97, 24, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 0, 32 };

        private readonly Among[] a_0;
        private readonly Among[] a_1;
        private readonly Among[] a_2;
        private readonly Among[] a_3;
        private readonly Among[] a_4;
        private readonly Among[] a_5;
        private readonly Among[] a_6;
        private readonly Among[] a_7;
        private readonly Among[] a_8;
        private readonly Among[] a_9;

        public FinnishStemmer()
        {
            a_0 = new[] 
            {
                new Among(UTF16("pa"), -1, 1),
                new Among(UTF16("sti"), -1, 2),
                new Among(UTF16("kaan"), -1, 1),
                new Among(UTF16("han"), -1, 1),
                new Among(UTF16("kin"), -1, 1),
                new Among(UTF16("h\u00C3\u00A4n"), -1, 1),
                new Among(UTF16("k\u00C3\u00A4\u00C3\u00A4n"), -1, 1),
                new Among(UTF16("ko"), -1, 1),
                new Among(UTF16("p\u00C3\u00A4"), -1, 1),
                new Among(UTF16("k\u00C3\u00B6"), -1, 1)
            };

            a_1 = new[] 
            {
                new Among(UTF16("lla"), -1, -1),
                new Among(UTF16("na"), -1, -1),
                new Among(UTF16("ssa"), -1, -1),
                new Among(UTF16("ta"), -1, -1),
                new Among(UTF16("lta"), 3, -1),
                new Among(UTF16("sta"), 3, -1)
            };

            a_2 = new[] 
            {
                new Among(UTF16("ll\u00C3\u00A4"), -1, -1),
                new Among(UTF16("n\u00C3\u00A4"), -1, -1),
                new Among(UTF16("ss\u00C3\u00A4"), -1, -1),
                new Among(UTF16("t\u00C3\u00A4"), -1, -1),
                new Among(UTF16("lt\u00C3\u00A4"), 3, -1),
                new Among(UTF16("st\u00C3\u00A4"), 3, -1)
            };

            a_3 = new[] 
            {
                new Among(UTF16("lle"), -1, -1),
                new Among(UTF16("ine"), -1, -1)
            };

            a_4 = new[] 
            {
                new Among(UTF16("nsa"), -1, 3),
                new Among(UTF16("mme"), -1, 3),
                new Among(UTF16("nne"), -1, 3),
                new Among(UTF16("ni"), -1, 2),
                new Among(UTF16("si"), -1, 1),
                new Among(UTF16("an"), -1, 4),
                new Among(UTF16("en"), -1, 6),
                new Among(UTF16("\u00C3\u00A4n"), -1, 5),
                new Among(UTF16("ns\u00C3\u00A4"), -1, 3)
            };

            a_5 = new[] 
            {
                new Among(UTF16("aa"), -1, -1),
                new Among(UTF16("ee"), -1, -1),
                new Among(UTF16("ii"), -1, -1),
                new Among(UTF16("oo"), -1, -1),
                new Among(UTF16("uu"), -1, -1),
                new Among(UTF16("\u00C3\u00A4\u00C3\u00A4"), -1, -1),
                new Among(UTF16("\u00C3\u00B6\u00C3\u00B6"), -1, -1)
            };

            a_6 = new[] 
            {
                new Among(UTF16("a"), -1, 8),
                new Among(UTF16("lla"), 0, -1),
                new Among(UTF16("na"), 0, -1),
                new Among(UTF16("ssa"), 0, -1),
                new Among(UTF16("ta"), 0, -1),
                new Among(UTF16("lta"), 4, -1),
                new Among(UTF16("sta"), 4, -1),
                new Among(UTF16("tta"), 4, 9),
                new Among(UTF16("lle"), -1, -1),
                new Among(UTF16("ine"), -1, -1),
                new Among(UTF16("ksi"), -1, -1),
                new Among(UTF16("n"), -1, 7),
                new Among(UTF16("han"), 11, 1),
                new Among(UTF16("den"), 11, -1, r_VI),
                new Among(UTF16("seen"), 11, -1, r_LONG),
                new Among(UTF16("hen"), 11, 2),
                new Among(UTF16("tten"), 11, -1, r_VI),
                new Among(UTF16("hin"), 11, 3),
                new Among(UTF16("siin"), 11, -1, r_VI),
                new Among(UTF16("hon"), 11, 4),
                new Among(UTF16("h\u00C3\u00A4n"), 11, 5),
                new Among(UTF16("h\u00C3\u00B6n"), 11, 6),
                new Among(UTF16("\u00C3\u00A4"), -1, 8),
                new Among(UTF16("ll\u00C3\u00A4"), 22, -1),
                new Among(UTF16("n\u00C3\u00A4"), 22, -1),
                new Among(UTF16("ss\u00C3\u00A4"), 22, -1),
                new Among(UTF16("t\u00C3\u00A4"), 22, -1),
                new Among(UTF16("lt\u00C3\u00A4"), 26, -1),
                new Among(UTF16("st\u00C3\u00A4"), 26, -1),
                new Among(UTF16("tt\u00C3\u00A4"), 26, 9)
            };

            a_7 = new[] 
            {
                new Among(UTF16("eja"), -1, -1),
                new Among(UTF16("mma"), -1, 1),
                new Among(UTF16("imma"), 1, -1),
                new Among(UTF16("mpa"), -1, 1),
                new Among(UTF16("impa"), 3, -1),
                new Among(UTF16("mmi"), -1, 1),
                new Among(UTF16("immi"), 5, -1),
                new Among(UTF16("mpi"), -1, 1),
                new Among(UTF16("impi"), 7, -1),
                new Among(UTF16("ej\u00C3\u00A4"), -1, -1),
                new Among(UTF16("mm\u00C3\u00A4"), -1, 1),
                new Among(UTF16("imm\u00C3\u00A4"), 10, -1),
                new Among(UTF16("mp\u00C3\u00A4"), -1, 1),
                new Among(UTF16("imp\u00C3\u00A4"), 12, -1)
            };

            a_8 = new[] 
            {
                new Among(UTF16("i"), -1, -1),
                new Among(UTF16("j"), -1, -1)
            };

            a_9 = new[] 
            {
                new Among(UTF16("mma"), -1, 1),
                new Among(UTF16("imma"), 0, -1)
            };

        }



        private bool r_mark_regions()
        {
            int v_1;
            int v_3;
            // (, line 41
            I_p1 = limit;
            I_p2 = limit;
            while (true) 
            {
                // goto, line 46
                v_1 = cursor;
                if (!(in_grouping(g_V1, 97, 246)))
                {
                    goto lab0;
                }
                cursor = v_1;
                break;
            lab0: 
                cursor = v_1;
                if (cursor >= limit)
                {
                    return false;
                }
                cursor++;
            }
            while (true) 
            {
                // gopast, line 46
                if (!(out_grouping(g_V1, 97, 246)))
                {
                    goto lab1;
                }
                break;
            lab1: 
                if (cursor >= limit)
                {
                    return false;
                }
                cursor++;
            }
            // setmark p1, line 46
            I_p1 = cursor;
            while (true) 
            {
                // goto, line 47
                v_3 = cursor;
                if (!(in_grouping(g_V1, 97, 246)))
                {
                    goto lab2;
                }
                cursor = v_3;
                break;
            lab2: 
                cursor = v_3;
                if (cursor >= limit)
                {
                    return false;
                }
                cursor++;
            }
            while (true) 
            {
                // gopast, line 47
                if (!(out_grouping(g_V1, 97, 246)))
                {
                    goto lab3;
                }
                break;
            lab3: 
                if (cursor >= limit)
                {
                    return false;
                }
                cursor++;
            }
            // setmark p2, line 47
            I_p2 = cursor;

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

        private bool r_particle_etc()
        {
            int among_var;
            int v_1;
            int v_2;
            // (, line 54
            // setlimit, line 55
            v_1 = limit - cursor;
            // tomark, line 55
            if (cursor < I_p1)
            {
                return false;
            }
            cursor = I_p1;
            v_2 = limit_backward;
            limit_backward = cursor;
            cursor = limit - v_1;
            // (, line 55
            // [, line 55
            ket = cursor;
            // substring, line 55
            among_var = find_among_b(a_0);
            if (among_var == 0)
            {
                limit_backward = v_2;
                return false;
            }
            // ], line 55
            bra = cursor;
            limit_backward = v_2;
            switch (among_var) 
            {
                case 0:
                    break;
                case 1:
                    // (, line 62
                    if (!(in_grouping_b(g_particle_end, 97, 246)))
                    {
                        return false;
                    }
                    break;
                case 2:
                    // (, line 64
                    // call R2, line 64
                    if (!r_R2())
                    {
                        return false;
                    }
                    break;
            }
            // delete, line 66
            slice_del();

            return true;
        }

        private bool r_possessive()
        {
            int among_var;
            int v_1;
            int v_2;
            int v_3;
            // (, line 68
            // setlimit, line 69
            v_1 = limit - cursor;
            // tomark, line 69
            if (cursor < I_p1)
            {
                return false;
            }
            cursor = I_p1;
            v_2 = limit_backward;
            limit_backward = cursor;
            cursor = limit - v_1;
            // (, line 69
            // [, line 69
            ket = cursor;
            // substring, line 69
            among_var = find_among_b(a_4);
            if (among_var == 0)
            {
                limit_backward = v_2;
                return false;
            }
            // ], line 69
            bra = cursor;
            limit_backward = v_2;
            switch (among_var) 
            {
                case 0:
                    break;
                case 1:
                    // (, line 72
                    // not, line 72

                    {
                        v_3 = limit - cursor;
                        // literal, line 72
                        if (!(eq_s_b(UTF16("k"))))
                        {
                            goto lab0;
                        }
                        return false;
                    lab0: 
                        cursor = limit - v_3;
                    }
                    // delete, line 72
                    slice_del();
                    break;
                case 2:
                    // (, line 74
                    // delete, line 74
                    slice_del();
                    // [, line 74
                    ket = cursor;
                    // literal, line 74
                    if (!(eq_s_b(UTF16("kse"))))
                    {
                        return false;
                    }
                    // ], line 74
                    bra = cursor;
                    // <-, line 74
                    slice_from(UTF16("ksi"));
                    break;
                case 3:
                    // (, line 78
                    // delete, line 78
                    slice_del();
                    break;
                case 4:
                    // (, line 81
                    // among, line 81
                    if (find_among_b(a_1) == 0)
                    {
                        return false;
                    }
                    // delete, line 81
                    slice_del();
                    break;
                case 5:
                    // (, line 83
                    // among, line 83
                    if (find_among_b(a_2) == 0)
                    {
                        return false;
                    }
                    // delete, line 84
                    slice_del();
                    break;
                case 6:
                    // (, line 86
                    // among, line 86
                    if (find_among_b(a_3) == 0)
                    {
                        return false;
                    }
                    // delete, line 86
                    slice_del();
                    break;
            }

            return true;
        }

        private bool r_LONG()
        {
            // among, line 91
            if (find_among_b(a_5) == 0)
            {
                return false;
            }

            return true;
        }

        private bool r_VI()
        {
            // (, line 93
            // literal, line 93
            if (!(eq_s_b(UTF16("i"))))
            {
                return false;
            }
            if (!(in_grouping_b(g_V2, 97, 246)))
            {
                return false;
            }

            return true;
        }

        private bool r_case_ending()
        {
            int among_var;
            int v_1;
            int v_2;
            int v_3;
            int v_4;
            int v_5;
            // (, line 95
            // setlimit, line 96
            v_1 = limit - cursor;
            // tomark, line 96
            if (cursor < I_p1)
            {
                return false;
            }
            cursor = I_p1;
            v_2 = limit_backward;
            limit_backward = cursor;
            cursor = limit - v_1;
            // (, line 96
            // [, line 96
            ket = cursor;
            // substring, line 96
            among_var = find_among_b(a_6);
            if (among_var == 0)
            {
                limit_backward = v_2;
                return false;
            }
            // ], line 96
            bra = cursor;
            limit_backward = v_2;
            switch (among_var) 
            {
                case 0:
                    break;
                case 1:
                    // (, line 98
                    // literal, line 98
                    if (!(eq_s_b(UTF16("a"))))
                    {
                        return false;
                    }
                    break;
                case 2:
                    // (, line 99
                    // literal, line 99
                    if (!(eq_s_b(UTF16("e"))))
                    {
                        return false;
                    }
                    break;
                case 3:
                    // (, line 100
                    // literal, line 100
                    if (!(eq_s_b(UTF16("i"))))
                    {
                        return false;
                    }
                    break;
                case 4:
                    // (, line 101
                    // literal, line 101
                    if (!(eq_s_b(UTF16("o"))))
                    {
                        return false;
                    }
                    break;
                case 5:
                    // (, line 102
                    // literal, line 102
                    if (!(eq_s_b(UTF16("\u00C3\u00A4"))))
                    {
                        return false;
                    }
                    break;
                case 6:
                    // (, line 103
                    // literal, line 103
                    if (!(eq_s_b(UTF16("\u00C3\u00B6"))))
                    {
                        return false;
                    }
                    break;
                case 7:
                    // (, line 111
                    // try, line 111
                    v_3 = limit - cursor;
                    // (, line 111
                    // and, line 113
                    v_4 = limit - cursor;
                    // or, line 112
                    v_5 = limit - cursor;
                    // call LONG, line 111
                    if (!r_LONG())
                    {
                        goto lab2;
                    }
                    goto lab1;
                lab2: 
                    cursor = limit - v_5;
                    // literal, line 112
                    if (!(eq_s_b(UTF16("ie"))))
                    {
                        cursor = limit - v_3;
                        goto lab0;
                    }
                lab1: 
                    cursor = limit - v_4;
                    // next, line 113
                    if (cursor <= limit_backward)
                    {
                        cursor = limit - v_3;
                        goto lab0;
                    }
                    cursor--;
                    // ], line 113
                    bra = cursor;
                lab0: 
                    break;
                case 8:
                    // (, line 119
                    if (!(in_grouping_b(g_V1, 97, 246)))
                    {
                        return false;
                    }
                    if (!(out_grouping_b(g_V1, 97, 246)))
                    {
                        return false;
                    }
                    break;
                case 9:
                    // (, line 121
                    // literal, line 121
                    if (!(eq_s_b(UTF16("e"))))
                    {
                        return false;
                    }
                    break;
            }
            // delete, line 138
            slice_del();
            // set ending_removed, line 139
            B_ending_removed = true;

            return true;
        }

        private bool r_other_endings()
        {
            int among_var;
            int v_1;
            int v_2;
            int v_3;
            // (, line 141
            // setlimit, line 142
            v_1 = limit - cursor;
            // tomark, line 142
            if (cursor < I_p2)
            {
                return false;
            }
            cursor = I_p2;
            v_2 = limit_backward;
            limit_backward = cursor;
            cursor = limit - v_1;
            // (, line 142
            // [, line 142
            ket = cursor;
            // substring, line 142
            among_var = find_among_b(a_7);
            if (among_var == 0)
            {
                limit_backward = v_2;
                return false;
            }
            // ], line 142
            bra = cursor;
            limit_backward = v_2;
            switch (among_var) 
            {
                case 0:
                    break;
                case 1:
                    // (, line 146
                    // not, line 146

                    {
                        v_3 = limit - cursor;
                        // literal, line 146
                        if (!(eq_s_b(UTF16("po"))))
                        {
                            goto lab0;
                        }
                        return false;
                    lab0: 
                        cursor = limit - v_3;
                    }
                    break;
            }
            // delete, line 151
            slice_del();

            return true;
        }

        private bool r_i_plural()
        {
            int v_1;
            int v_2;
            // (, line 153
            // setlimit, line 154
            v_1 = limit - cursor;
            // tomark, line 154
            if (cursor < I_p1)
            {
                return false;
            }
            cursor = I_p1;
            v_2 = limit_backward;
            limit_backward = cursor;
            cursor = limit - v_1;
            // (, line 154
            // [, line 154
            ket = cursor;
            // substring, line 154
            if (find_among_b(a_8) == 0)
            {
                limit_backward = v_2;
                return false;
            }
            // ], line 154
            bra = cursor;
            limit_backward = v_2;
            // delete, line 158
            slice_del();

            return true;
        }

        private bool r_t_plural()
        {
            int among_var;
            int v_1;
            int v_2;
            int v_3;
            int v_4;
            int v_5;
            int v_6;
            // (, line 160
            // setlimit, line 161
            v_1 = limit - cursor;
            // tomark, line 161
            if (cursor < I_p1)
            {
                return false;
            }
            cursor = I_p1;
            v_2 = limit_backward;
            limit_backward = cursor;
            cursor = limit - v_1;
            // (, line 161
            // [, line 162
            ket = cursor;
            // literal, line 162
            if (!(eq_s_b(UTF16("t"))))
            {
                limit_backward = v_2;
                return false;
            }
            // ], line 162
            bra = cursor;
            // test, line 162
            v_3 = limit - cursor;
            if (!(in_grouping_b(g_V1, 97, 246)))
            {
                limit_backward = v_2;
                return false;
            }
            cursor = limit - v_3;
            // delete, line 163
            slice_del();
            limit_backward = v_2;
            // setlimit, line 165
            v_4 = limit - cursor;
            // tomark, line 165
            if (cursor < I_p2)
            {
                return false;
            }
            cursor = I_p2;
            v_5 = limit_backward;
            limit_backward = cursor;
            cursor = limit - v_4;
            // (, line 165
            // [, line 165
            ket = cursor;
            // substring, line 165
            among_var = find_among_b(a_9);
            if (among_var == 0)
            {
                limit_backward = v_5;
                return false;
            }
            // ], line 165
            bra = cursor;
            limit_backward = v_5;
            switch (among_var) 
            {
                case 0:
                    break;
                case 1:
                    // (, line 167
                    // not, line 167

                    {
                        v_6 = limit - cursor;
                        // literal, line 167
                        if (!(eq_s_b(UTF16("po"))))
                        {
                            goto lab0;
                        }
                        return false;
                    lab0: 
                        cursor = limit - v_6;
                    }
                    break;
            }
            // delete, line 170
            slice_del();

            return true;
        }

        private bool r_tidy()
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
            // (, line 172
            // setlimit, line 173
            v_1 = limit - cursor;
            // tomark, line 173
            if (cursor < I_p1)
            {
                return false;
            }
            cursor = I_p1;
            v_2 = limit_backward;
            limit_backward = cursor;
            cursor = limit - v_1;
            // (, line 173
            // do, line 174
            v_3 = limit - cursor;
            // (, line 174
            // and, line 174
            v_4 = limit - cursor;
            // call LONG, line 174
            if (!r_LONG())
            {
                goto lab0;
            }
            cursor = limit - v_4;
            // (, line 174
            // [, line 174
            ket = cursor;
            // next, line 174
            if (cursor <= limit_backward)
            {
                goto lab0;
            }
            cursor--;
            // ], line 174
            bra = cursor;
            // delete, line 174
            slice_del();
        lab0: 
            cursor = limit - v_3;
            // do, line 175
            v_5 = limit - cursor;
            // (, line 175
            // [, line 175
            ket = cursor;
            if (!(in_grouping_b(g_AEI, 97, 228)))
            {
                goto lab1;
            }
            // ], line 175
            bra = cursor;
            if (!(out_grouping_b(g_V1, 97, 246)))
            {
                goto lab1;
            }
            // delete, line 175
            slice_del();
        lab1: 
            cursor = limit - v_5;
            // do, line 176
            v_6 = limit - cursor;
            // (, line 176
            // [, line 176
            ket = cursor;
            // literal, line 176
            if (!(eq_s_b(UTF16("j"))))
            {
                goto lab2;
            }
            // ], line 176
            bra = cursor;
            // or, line 176
            v_7 = limit - cursor;
            // literal, line 176
            if (!(eq_s_b(UTF16("o"))))
            {
                goto lab4;
            }
            goto lab3;
        lab4: 
            cursor = limit - v_7;
            // literal, line 176
            if (!(eq_s_b(UTF16("u"))))
            {
                goto lab2;
            }
        lab3: 
            // delete, line 176
            slice_del();
        lab2: 
            cursor = limit - v_6;
            // do, line 177
            v_8 = limit - cursor;
            // (, line 177
            // [, line 177
            ket = cursor;
            // literal, line 177
            if (!(eq_s_b(UTF16("o"))))
            {
                goto lab5;
            }
            // ], line 177
            bra = cursor;
            // literal, line 177
            if (!(eq_s_b(UTF16("j"))))
            {
                goto lab5;
            }
            // delete, line 177
            slice_del();
        lab5: 
            cursor = limit - v_8;
            limit_backward = v_2;
            while (true) 
            {
                // goto, line 179
                v_9 = limit - cursor;
                if (!(out_grouping_b(g_V1, 97, 246)))
                {
                    goto lab6;
                }
                cursor = limit - v_9;
                break;
            lab6: 
                cursor = limit - v_9;
                if (cursor <= limit_backward)
                {
                    return false;
                }
                cursor--;
            }
            // [, line 179
            ket = cursor;
            // next, line 179
            if (cursor <= limit_backward)
            {
                return false;
            }
            cursor--;
            // ], line 179
            bra = cursor;
            // -> x, line 179
            S_x = slice_to(S_x);
            // name x, line 179
            if (!(eq_s_b(S_x)))
            {
                return false;
            }
            // delete, line 179
            slice_del();

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
            // (, line 183
            // do, line 185
            v_1 = cursor;
            // call mark_regions, line 185
            if (!r_mark_regions())
            {
                goto lab0;
            }
        lab0: 
            cursor = v_1;
            // unset ending_removed, line 186
            B_ending_removed = false;
            // backwards, line 187
            limit_backward = cursor; cursor = limit;
            // (, line 187
            // do, line 188
            v_2 = limit - cursor;
            // call particle_etc, line 188
            if (!r_particle_etc())
            {
                goto lab1;
            }
        lab1: 
            cursor = limit - v_2;
            // do, line 189
            v_3 = limit - cursor;
            // call possessive, line 189
            if (!r_possessive())
            {
                goto lab2;
            }
        lab2: 
            cursor = limit - v_3;
            // do, line 190
            v_4 = limit - cursor;
            // call case_ending, line 190
            if (!r_case_ending())
            {
                goto lab3;
            }
        lab3: 
            cursor = limit - v_4;
            // do, line 191
            v_5 = limit - cursor;
            // call other_endings, line 191
            if (!r_other_endings())
            {
                goto lab4;
            }
        lab4: 
            cursor = limit - v_5;
            // or, line 192
            v_6 = limit - cursor;
            // (, line 192
            // Boolean test ending_removed, line 192
            if (!(B_ending_removed))
            {
                goto lab6;
            }
            // do, line 192
            v_7 = limit - cursor;
            // call i_plural, line 192
            if (!r_i_plural())
            {
                goto lab7;
            }
        lab7: 
            cursor = limit - v_7;
            goto lab5;
        lab6: 
            cursor = limit - v_6;
            // do, line 192
            v_8 = limit - cursor;
            // call t_plural, line 192
            if (!r_t_plural())
            {
                goto lab8;
            }
        lab8: 
            cursor = limit - v_8;
        lab5: 
            // do, line 193
            v_9 = limit - cursor;
            // call tidy, line 193
            if (!r_tidy())
            {
                goto lab9;
            }
        lab9: 
            cursor = limit - v_9;
            cursor = limit_backward;

            return true;
        }

        protected override bool Process()
        {
            return this.stem();
        }

    }
}

