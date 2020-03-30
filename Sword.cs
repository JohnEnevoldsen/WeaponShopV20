namespace WeaponShopV20
{
    public class Sword : Weapon
    {
        public const int InitialSwordMinDamage = 20;
        public const int InitialSwordMaxDamage = 30;
        private bool _isEnchanted;
        public Sword(string description) : base(description, InitialSwordMinDamage, InitialSwordMaxDamage){
            _isEnchanted = false;
        }
        public bool IsEnchanted
        {
            get { return _isEnchanted; }
            set { _isEnchanted = value; }
        }
    }
}