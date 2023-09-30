using DungeonLibrary;
namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Weapon w = new Weapon();
            w.Type = WeaponType.Nunchaku;
            w.BonusHitChance = 0;
            
            Player play = new Player();
            play.HitChance = 40;
           //play.EquippedWeapon.BonusHitChance = 30;
            int expected = 40;
            int actual = play.CalcHitChance();
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test2()
        {
            Player play = new Player();
            play.Name = "Ah Sahm";
            //play.EquippedWeapon.BonusHitChance = 30;
            string expected = "Ah Sahm";
            string actual = play.playername(play);
            Assert.Equal(expected, actual);
        }
    }
}