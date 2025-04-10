```mermaid
Character <|-- Player
Character <|-- Enemy
Weapon <|-- Gun
Weapon <|-- Sword
Character o-- Weapon

    class Character {
        #Weapon[] weapons
        +string Name
        +Fight()
    }

    class Player {
        +Player(string name)
    }

    class Enemy {
        +Enemy(string name)
    }

    class Weapon {
        #float power
        +Weapon(float power)
    }

    class Gun {
        +int Ammo
        +Gun(float power, int ammo)
        +FireGun()
    }

    class Sword {
        +float length
        +Sword(float power, float length)
        +AttackWithSword()
    }
```