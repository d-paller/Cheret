export class CardModel {
    title: string;
    cardHtml: string;
    imageUrl: string;

    constructor(title: string, cardHtml: string) {
        this.title = title;
        this.cardHtml = cardHtml;
    }
}