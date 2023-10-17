using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace CookiesExample
{
    public class Cookie
    {
        //קבועים רמת קושי מתכון
       public const int EASY = 0;
       public const int MEDIUM = 1;
       public const int HARD= 2;  


        protected int level;//דרגת קושי
        protected int duration;//משך זמן הכנה
        protected string flavor;//טעם
        protected int calories;//כמות הקלוריות


        #region פעולה בונה
        /// <summary>
        /// פעולה בונה לעוגיה
        /// </summary>
        /// <param name="level">דרגת קושי</param>
        /// <param name="duration">משך הכנה</param>
        /// <param name="flavor">טעם</param>
        /// <param name="calories">קלוריות</param>
        public Cookie(int level, int duration,string flavor, int calories )
        {
            this.level = level;
            this.duration = duration;
            this.flavor = flavor;
            this.calories = calories;
        }
        #endregion

        #region פעולה בונה מעתיקה
        public Cookie(Cookie cookie):this(cookie.level,cookie.duration,cookie.flavor,cookie.calories)
        {}
        #endregion

        #region Getters
        public int GetLevel()
        { return level; }
        public int GetMinutes() { return duration; }
        public string GetFlavor() { return flavor; }
        public int GetCalories() {  return calories; }

        #endregion

        #region Setters
        public void SetLevel(int level)
        { 
            if(level>=EASY&&level<=HARD)
                this.level = level;
        }

        public void SetDuration(int minutes)
        { this.duration = minutes; }

        public void SetFlavor(string flavor)
        { this.flavor = flavor; }

        public void SetCalories(int calories)
        { this.calories = calories; }
        #endregion

        #region פעולה מתארת
        public override string ToString()
        {
            string str = $"Cookie:Duration:{duration} Difficulty:";
            switch (level)
            {
                case EASY:
                    str += "Easy";
                    break;
                case MEDIUM:
                    str += "Medium";
                    break;
                case HARD:
                    str += "Hard";
                    break;
                default:
                    str += "Unknown";
                    break;
            }

            return str += $" Flavor:{flavor} Calories:{calories}";
        }
        #endregion






    }


    public class ChocolateCookie:Cookie
    {
      
        //נוסיף את מספר השוקולד צ'יפ שנדרש
        private int chocolateChips;


        #region פעולה בונה
        public ChocolateCookie(int level, int duration, string flavor, int calories, int chocolateChips):base(level,duration,flavor,calories)
        {
           
            this.chocolateChips = chocolateChips;
        }
        #endregion

        #region פעולה בונה מעתיקה
        public ChocolateCookie(ChocolateCookie cookie) : base(cookie)
        {
            this.chocolateChips = cookie.chocolateChips;
        }
        #endregion

        //#region Getters
        //public int GetLevel()
        //{ return level; }
        //public int GetDuration2() { return duration; }
        //public string GetFlavor() { return flavor; }
        //public int GetCalories() { return calories; }

        //public int GetChocolateChips() { return chocolateChips; }

        //#endregion

        //#region Setters
        //public void SetLevel(int level)
        //{
        //    if (level >= EASY && level <= HARD)
        //        this.level = level;
        //}

        //public void SetDuration(int minutes)
        //{ this.duration = minutes; }

        //public void SetFlavor(string flavor)
        //{ this.flavor = flavor; }

        //public void SetCalories(int calories)
        //{ this.calories = calories; }

        //public void SetChocolateChips(int chocolateChips)
        //{  this.chocolateChips=chocolateChips; }    
        //#endregion

        #region פעולה מתארת
        public override string ToString()
        {
         

            return  $"{base.ToString()} ChocolateChip:{chocolateChips}";
        }
        #endregion

    }
}
