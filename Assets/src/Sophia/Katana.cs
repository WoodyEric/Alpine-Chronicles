using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katana : ItemClass
{
    private readonly string _itemName;
    private int _strength;
    private int _health;

    private Sprite _spriteImage;
    private (int str, int len) _tempStrength;
    private (int spd, int len) _tempSpeed;

    public Katana()
    {
        _itemName = "Katana";
        _strength = 4;
        _health = -1; // error state, if the thing doesnt change it
        _tempStrength = (-1, -1);
        _tempSpeed = (-1, -1); //if speed, first number is increase by how much, and second is for how long in seconds
        _spriteImage = Resources.Load<Sprite>("Items Pack/Pixel Art Icon Pack - RPG/Texture/Weapon & Tool/Golden Sword.png");

    }

    public override string itemName
    {
        get {return _itemName;}
    }

    public override Sprite spriteImage
    {
        get {return _spriteImage;}
    }
    public override int strength
    {
        get {return _strength;}
    }
    public override int health
    {
        get {return _health;}
    }


    public override (int, int) tempStrength
    {
        get {return _tempStrength;}
    }

    public override (int, int) tempSpeed
    {
        get {return _tempSpeed;}
    }
}