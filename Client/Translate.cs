﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Translate
    {
        public Translate()
        {
        }

        public virtual string UserInterface(int Code)
        {
            return null;
        }

        public virtual string Map(int Code)
        {
            return null;
        }

        public virtual string Item(int Code)
        {
            return null;
        }

        public virtual string Monster(int Code)
        {
            return null;
        }

        public virtual string NPC(int Code)
        {
            return null;
        }

        public virtual string Skill(int Code)
        {
            return null;
        }
    }

    public class Korean : Translate
    {
        public override string UserInterface(int Code)
        {
            string result = null;
            switch (Code)
            {
                case 0: result = null; break;
            }

            return result;
        }

        public override string Map(int Code)
        {
            string result = null;
            switch (Code)
            {
                case 0: result = null; break;
            }

            return result;
        }

        public override string Item(int Code)
        {
            string result = null;
            switch (Code)
            {
                case 0: result = null; break;
            }

            return result;
        }

        public override string Monster(int Code)
        {
            string result = null;
            switch (Code)
            {
                case 0: result = null; break;
            }

            return result;
        }

        public override string NPC(int Code)
        {
            string result = null;
            switch (Code)
            {
                case 0: result = null; break;
            }

            return result;
        }

        public override string Skill(int Code)
        {
            string result = null;
            switch (Code)
            {
                case 0: result = null; break;
            }

            return result;
        }
    }

}