import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'chore',
    templateUrl: './chore.component.html'
})

export class ChoreComponent {
    chores: Chore[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string)
    {
        http.get(baseUrl + 'api/chores').subscribe(result => { this.chores = result.json() as Chore[]; }, error => console.error(error))
    }
}

interface Chore
{
    id: Number,
    name: string,
    description: string
}