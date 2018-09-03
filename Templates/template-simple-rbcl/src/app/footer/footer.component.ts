import { Component, OnInit } from '@angular/core';
import { CardModel } from '../models/cardModel';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {

  optionalInfoCard: CardModel;
  servicesCard: CardModel;
  contactCard: CardModel;

  constructor() { }

  ngOnInit() {
    this.optionalInfoCard = new CardModel("Optional", "<div> Optional info stuff. </div>");
    this.servicesCard = new CardModel("Services", "<div> <p>Sundays 8am, 11:30am and 5pm</p><p>Prayer meeting: Wednesdays at 7pm</p></div>");
    this.contactCard = new CardModel("Contact", "<div>Address: 12345 xyz abc <p>Phone: (435)234-6789</p></div> ");
  }

}
