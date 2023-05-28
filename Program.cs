// See https://aka.ms/new-console-template for more information


// пълнене на Main-a

using MertsFootballModel;

Coach barcelonaCoach = new Coach("Xavi Hernandez", 41);
Coach realMadridCoach = new Coach("George Troons", 45);

FootballPlayer barcelonaPlayer1 = new Goalkeeper("Ter Stegen", 31, 1, 1.87);
FootballPlayer barcelonaPlayer2 = new Midfielder("George Famiger", 21, 3, 1.84);
FootballPlayer barcelonaPlayer3 = new Midfielder("Ivan Georgiev", 24, 4, 1.79);
FootballPlayer barcelonaPlayer4 = new Defenderf("Tony Reager", 25, 5, 1.90);
FootballPlayer barcelonaPlayer5 = new Defenderf("Clay Gooper", 30, 6, 1.81);
FootballPlayer barcelonaPlayer6 = new Defenderf("Albert Hoohen", 22, 7, 1.80);
FootballPlayer barcelonaPlayer7 = new Defenderf("Tooring Goohauh", 32, 8, 1.92);
FootballPlayer barcelonaPlayer8 = new Midfielder("Sebastian Sebo", 25, 9, 1.93);
FootballPlayer barcelonaPlayer = new Striker("Mert Mustafa", 20, 10, 1.80);
FootballPlayer barcelonaPlayer10 = new Striker("Tsurugi Kyosuke", 20, 11, 1.83);
FootballPlayer barcelonaPlayer11 = new Striker("Leonel Messi", 28, 9, 1.84);

FootballPlayer realMadridPlayer1 = new Goalkeeper("Ghasd Trsd", 32, 32, 1.80);
FootballPlayer realMadridPlayer2 = new Defenderf("Rertw Ergeno", 27, 2, 1.76);
FootballPlayer realMadridPlayer3 = new Defenderf("Kuioh Geroo", 26, 13, 1.87);
FootballPlayer realMadridPlayer4 = new Defenderf("Gakuen Poolen", 23, 3, 1.89 );
FootballPlayer realMadridPlayer5 = new Defenderf("Corgen Stecken", 29, 5, 1.79);
FootballPlayer realMadridPlayer6 = new Midfielder("Mich Lawrence", 30, 7, 1.80);
FootballPlayer realMadridPlayer7 = new Midfielder("Lorenzo Guevarra", 23, 8, 1.90);
FootballPlayer realMadridPlayer8 = new Midfielder("Ogre Tohosd", 24, 15, 1.89);
FootballPlayer realMadridPlayer9 = new Midfielder("Trew Throh", 30, 10, 1.94);
FootballPlayer realMadridPlayer10 = new Striker("Fooren Goleeh", 20, 11, 1.82);
FootballPlayer realMadridPlayer11 = new Striker("Christiano ROnaldo", 34, 9, 1.87);

List<FootballPlayer> barcaSelection = new List<FootballPlayer>();
barcaSelection.Add(barcelonaPlayer);
barcaSelection.Add(barcelonaPlayer1);
barcaSelection.Add(barcelonaPlayer2);
barcaSelection.Add(barcelonaPlayer3);
barcaSelection.Add(barcelonaPlayer4);
barcaSelection.Add(barcelonaPlayer5);
barcaSelection.Add(barcelonaPlayer6);
barcaSelection.Add(barcelonaPlayer7);
barcaSelection.Add(barcelonaPlayer8);
barcaSelection.Add(barcelonaPlayer10);
barcaSelection.Add(barcelonaPlayer11);

List<FootballPlayer> realSelection = new List<FootballPlayer>();
realSelection.Add(realMadridPlayer1);
realSelection.Add(realMadridPlayer2);
realSelection.Add(realMadridPlayer3);
realSelection.Add(realMadridPlayer4);
realSelection.Add(realMadridPlayer5);
realSelection.Add(realMadridPlayer6);
realSelection.Add(realMadridPlayer7);
realSelection.Add(realMadridPlayer8);
realSelection.Add(realMadridPlayer9);
realSelection.Add(realMadridPlayer10);
realSelection.Add(realMadridPlayer11);

Team barcelona = new Team(barcelonaCoach, barcaSelection);
Team realMadrid = new Team(realMadridCoach, realSelection);

Referee gameReferee = new Referee("Gogu Hadjiiski", 39);

Game game = new Game(barcelona, realMadrid, gameReferee);
game.AddGoal(23, realMadridPlayer11);
game.AddGoal(39, barcelonaPlayer);
game.AddGoal(72, barcelonaPlayer10);

game.GetGameREsults();