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

  constructor() {

   }

  ngOnInit() {
    this.recentSermonsCard = new CardModel('Recent Sermons', '<ul><li>Sermon 1</li><li>Sermon 2</li></ul>');
    //console.log("Home init: " + this.recentSermonsCard.title + " "+ this.recentSermonsCard.cardHtml);

  }

  log(val){
    console.log(val);
  }

}
