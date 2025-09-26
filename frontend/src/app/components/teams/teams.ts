import { Component, OnInit } from '@angular/core';
import {Field} from '../field/field';


@Component({
  selector: 'app-teams',
  standalone: true,
  imports: [
    Field
  ],
  templateUrl: './teams.html',
  styleUrl: './teams.css'
})
export class Teams {
  ngOnInit() {

  }

}
