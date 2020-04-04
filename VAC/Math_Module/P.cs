﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Module
{
    public struct M
    {
        public Q coaf;
        public N step;

        public M(Q c, N s)
        {
            coaf = null;
            step = null;
        }
    }

    public class P:Math_Field
    {
        #region Конструкторы

        public P(List<string> s)
        {

        }

        public P(Q value)
        {

        }

        #endregion

        #region Поля

        List<M> Ms;

        #endregion

        #region Свойства

        public override bool isDown
        {
            get
            {
                return Convert.ToBoolean(new Exception());
            }
        }

        public Q LED_P_Q
        {
            get
            {
                return null;
            }
        }

        public N DEG_P_N
        {
            get
            {
                return null;
            }
        }

        private Q FAC_P_Q
        {
            get
            {
                return null;
            }
        }

        public P DER_P_P
        {
            get
            {
                P result = this.Clone();
                if (result.Ms[Ms.Count() - 1].step.NZER_N_B)
                {
                    result.Ms.RemoveAt(Ms.Count() - 1);
                }
                List<string> odin = new List<string>();
                odin.Add("1");
                N one = new N(odin);
                M now;
                for (int i = result.Ms.Count() - 1; i > 0; i--)
                {
                    result.Ms.Insert(i, Ms[i]);
                    now = result.Ms[i];
                    now.coaf *= (Z)now.step;
                    now.step -= one;
                    result.Ms[i] = now;
                    result.Ms.RemoveAt(i + 1);
                }
                return result;
            }
        }

        #endregion

        #region Перегрузки

        public static P operator +(P first, P second) // ADD_PP_P
        {
            P result;
            P smaller;
            if (first.Ms.Count() < second.Ms.Count())
            {
                result = second.Clone();
                smaller = first.Clone();
            }
            else
            {
                result = first.Clone();
                smaller = second.Clone();
            }
            M now;
            for (int i = 0; i < smaller.Ms.Count(); i++)
            {
                for (int j = 0; j < result.Ms.Count(); j++)
                {
                    if (N.COM_NN_D(result.Ms[j].step, smaller.Ms[i].step) == 0)
                    {
                        now = result.Ms[j];
                        now.coaf += smaller.Ms[i].coaf;
                        result.Ms[j] = now;
                        break;
                    }
                    if (N.COM_NN_D(result.Ms[j].step, smaller.Ms[i].step) == 1)
                    {
                        result.Ms.Insert(j, smaller.Ms[i]);
                        break;
                    }
                }
            }
            return result;
        }

        public static P operator -(P first, P second) // SUB_PP_P
        {
            P result;
            P smaller;
            if (first.Ms.Count() < second.Ms.Count())
            {
                result = second.Clone();
                smaller = first.Clone();
            }
            else
            {
                result = first.Clone();
                smaller = second.Clone();
            }
            M now;
            for (int i = 0; i < smaller.Ms.Count(); i++)
            {
                now = smaller.Ms[i];
                now.coaf = -now.coaf;
                smaller.Ms[i] = now;
            }
            result += smaller;
            return result;
        }

        public static P operator *(P first, P second) // MUL_PP_P
        {
            return null;
        }

        public static P operator /(P first, P second) // DIV_PP_P
        {
            return null;
        }

        public static P operator %(P first, P second) // MOD_PP_p
        {
            return null;
        }

        public static implicit operator List<string>(P value)
        {
            return null;
        }

        public static explicit operator Q(P value)
        {
            return null;
        }

        public override bool Equals(object obj)
        {
            if(obj.GetType() == GetType() && this != null && obj != null)
            {
                P sec = obj as P;
                if (Ms.Equals(sec.Ms)) return true;
            }
            return false;
        }

        #endregion

        #region Методы

        private P MUL_PQ_P(Q value)
        {
            return null;
        }

        private P MUL_Pxk_P(N value)
        {
            return null;
        }

        public static P GCF_PP_P(P first, P second)
        {
            return null;
        }

        private void NMR_P_P()
        {

        }
        
        public P Clone() // Александр Баталин 9370//
        {
            P clone = new P(new List<string>());
            clone.Ms = new List<M>(Ms);
            return clone;
        }

        #endregion
    }
}
