using System;
public class Game 
{

    public Game () 
    {
        Health.power = 100;
        Health.message = "You are getting stronger.";
        Ammo.message = "You have more ammo";
        Console.WriteLine(Health.power);
        Console.WriteLine(Ammo.power);
    }

    public void Start ()
    {
        Health.RunPowerUp();
    }
    /*
    After prompt the game for a name we:
    enter a cave and find health.
    Meet a dragon (need enemy class)
    Pick Weapon
    battle dragon
    if we win get health and ammo
    if gdragon wins loose health 

    */

    //Game PowerUps 
    public PowerUpBase Health = new PowerUpBase();
    public PowerUpBase Ammo = new PowerUpBase();

    //Game Weapons
    private WeaponBase Gun = new WeaponBase();
    private WeaponBase Rifle = new WeaponBase();
    private WeaponBase Knife = new WeaponBase();

    public string name;
    private int score;

}