using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IconicaPieces
{
    public class Card
    {
        public int Health { get; private set; }
        public string Name { get; private set; }
        public CharacterClass Class { get; private set; }
        public Faction Faction { get; private set; }
        public List<StatusEffect> StatusEffects { get; private set; }
        public string StrengthBonus { get; private set; }
        public CharacterType Type { get; private set; }
        

        public Card()
        {
            //TODO Implement Card Default Constructor
#if DEBUG
            Name = "Blank";
            Health = 200;
            Class = IconicaPieces.CharacterClass.Offensive;
            Faction = Faction.Independant;
#endif
        }

        public void ApplyStatusEffect(StatusEffect se)
        {
            StatusEffects.Add(se);
        }
        public void RemoveStatusEffect(StatusEffect se)
        {
            StatusEffects.Remove(se);
        }
        public List<StatusEffect> ShowStatusEffects()
        {
            return StatusEffects;
        }
        
        public void TakeDamage(int d)
        {
            Health -= d;
        }
        public void Heal(int h)
        {
            Health += h;
        }
        
    }
    public enum Faction
    {
        Independant,
        Legion,
        Protectorate
    }
    public enum CharacterClass
    {
        Offensive,
        Defensive,
        Disruptive,
        Supportive,
        Adaptive
    }
    public enum StatusEffect
    {
        Poison,
        Fear,
        Stun,
        Confusion,
        Blind,
        Venom,
        Toxin,
        Sleep
    }

    public enum CharacterType
    {
        Common, 
        Uncommon,
        Rare,
        Special,
        Legend
    }
}
