import { Component, OnInit } from '@angular/core';
import { TitledCardComponent } from "../titled-card/titled-card.component";
import { CardModel } from '../models/cardModel';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  recentSermonsCard: CardModel;
  calendarEventsCard: CardModel;
  welcomeCard: CardModel;

  constructor() {

   }

  ngOnInit() {
    this.recentSermonsCard = new CardModel('Recent Sermons', '<ul><li>Sermon 1</li><li>Sermon 2</li></ul>');
    //console.log("Home init: " + this.recentSermonsCard.title + " "+ this.recentSermonsCard.cardHtml);

    this.calendarEventsCard = new CardModel('Upcoming Events', '<ul><li>Sunday Service</li> <li>Small Groups</li><li>Prayer Meeting</li></ul>');
    this.welcomeCard = new CardModel(null, "<p>Welcome to this church!  We hope that you will be blessed by the worship and that you feel welcomed by God's people.  If you have any questions please don't hesitate to call the office.</p>");
    this.welcomeCard.imageUrl = './src/images/c.jpg';
  }

  log(val){
    console.log(val);
  }

}
