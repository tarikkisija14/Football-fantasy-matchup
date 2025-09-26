import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import{HttpClient} from '@angular/common/http';
import{FormsModule} from '@angular/forms';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('frontend');
}
