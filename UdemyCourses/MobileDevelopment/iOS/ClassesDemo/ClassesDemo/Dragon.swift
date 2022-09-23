class Dragon: Enemy {
    var wingSpan = 2
    
    func talk(speech: String){
        print("\(speech)")
    }
    
    override func move() {
        print("Fly forward")
    }
    
    override func attack() {
        super.attack()
        print("Spits fire, does \(attackStrength) damage")
    }
}
