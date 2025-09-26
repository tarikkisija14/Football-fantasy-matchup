import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import{HttpClient} from '@angular/common/http';
import{FormsModule} from '@angular/forms';
import {Teams} from './components/teams/teams';

@Component({
  selector: 'app-root',
  standalone:true,
  imports: [RouterOutlet, FormsModule, Teams],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('Football Fantasy Matchup');
}
