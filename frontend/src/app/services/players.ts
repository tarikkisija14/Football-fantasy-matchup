import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Player} from '../models/player';

@Injectable({
  providedIn: 'root'
})
export class Players {
  private apiUrl="http://localhost:5001/api/players";

  constructor(private http: HttpClient) { }

  getAllPlayers():Observable<Player[]>{
    return this.http.get<Player[]>(this.apiUrl);
  }

  getPlayersByClub(club:string):Observable<Player[]>{
    return this.http.get<Player[]>(`${this.apiUrl}/club/${club}`);
  }

  getPlayersByNation(nation: string): Observable<Player[]> {
    return this.http.get<Player[]>(`${this.apiUrl}/nation/${nation}`);
  }

  getPlayerByName(name: string): Observable<Player> {
    return this.http.get<Player>(`${this.apiUrl}/name/${name}`);
  }

  getPlayersByPosition(position: string): Observable<Player[]> {
    return this.http.get<Player[]>(`${this.apiUrl}/position/${position}`);
  }

}
