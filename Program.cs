namespace G_NET_12_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Quesion 1

            /*
             * الـ Owner و Balance معمولين public → أي حد يغيرهم بدون تحكم 
               مفيش validation في Withdraw → ممكن يسحب أكتر من الرصيد 
            ----------------------------------------------------------------------
            نخليهم private
            نستخدم properties عشان نتحكم فيهم
             * ----------------------------------------------------------------------
             * بيكسر Encapsulation
             * مفيش تحكم على البيانات
             */

            #endregion

            #region Quesion 2

            // Field → متغير عادي
            //Property → فيها logic(get / set)
            //example:
            //    private double price;

            //public double Price
            //{
            //    get { return price; }
            //    set { if (value > 0) price = value; }
            //}

            //public double PriceAfterTax
            //{
            //    get { return price * 1.14; }
            //}

            #endregion

            #region Quesion 3

            //ده اسمه Indexer
            //وبيخليك تتعامل مع الكلاس زي array
            //b) هيعمل ايرور
            //الحل: set
            //{
            //    if (index >= 0 && index < names.Length)
            //        names[index] = value;
            //}
            //c) اه ممكن
            #endregion

        }
    }
}
