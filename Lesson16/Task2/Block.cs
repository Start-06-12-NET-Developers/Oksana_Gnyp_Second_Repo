namespace Lesson16
{
    public class Block 
    {
        private int firstSide;
        private int secondSide;
        private int thirdSide;
        private int foutrhSide;

        public Block(int firstSide)
        {
            this.firstSide = this.secondSide = this.thirdSide = this.foutrhSide = firstSide;
        }

        public Block(int firstSide, int secondSide)
        {
            this.firstSide = this.thirdSide = firstSide;
            this.secondSide = this.foutrhSide = secondSide;
        }

        public override bool Equals(object obj)
        {
            if(obj is Block)
            {
                Block compareBlock = (Block)obj;
                return this.firstSide == compareBlock.firstSide && this.secondSide == compareBlock.secondSide
                       && this.thirdSide == compareBlock.thirdSide && this.foutrhSide == compareBlock.foutrhSide;
            }

            return false;
        }

        public override string ToString()
        {
            return string.Format("First side = {0}, \nSecond side = {1} \nThird side = {2} \nFourth side = {3}",
                                 firstSide, secondSide, thirdSide, foutrhSide);
        }
    }
}
