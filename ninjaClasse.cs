namespace classes;
// public class Wizard : Human
// {

//     public Wizard(string name, int str ,int dex, int intel = 25, int hp = 50) : base(name, str,intel, dex,hp)
//     {
//     }


//     public  int Attack(Human target){
//         int damage = Intelligence * 5;
//         target.Health -= damage;
//         Health  += damage;
//         return target.Health;
//     }

//     public int Heal(Human target){
//         target.Health += 10 * Intelligence;
//         return target.Health;
//     }
// }





public class Wizard : Human {

    public Wizard(string name) : base (name){
        Health = 50;
        Intelligence = 25;
    }

    public override int Attack(Human target){
        int damage = Intelligence * 5;
        target.Health -= damage;
        Health += damage;
        return target.Health;
    }

    public int Heal(Human target){
        target.Health += 10 * Intelligence;
        return target.Health;
    }
}