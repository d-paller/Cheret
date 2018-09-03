import { Component, OnInit, Input } from '@angular/core';
import { CardModel } from "../models/cardModel";

@Component({
  selector: 'app-titled-card',
  templateUrl: './titled-card.component.html',
  styleUrls: ['./titled-card.component.css']
})
export class TitledCardComponent implements OnInit {
  
  @Input() 
  cardModel: CardModel;
  
  constructor() { 
    
  }

  ngOnInit() {
    console.log("card init: " + this.cardModel.title + " "+ this.cardModel.cardHtml);
  }

}
