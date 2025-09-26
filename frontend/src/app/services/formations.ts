import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import{Formation} from '../models/formation';


@Injectable({
  providedIn: 'root'
})
export class Formations {
  private apiUrl = 'https://localhost:5001/api/formations';

  constructor(private http: HttpClient) {}

  getAllFormations():Observable<Formation[]>{
    return this.http.get<Formation[]>(this.apiUrl);
  }

  getFormationById(id:number):Observable<Formation>{
    return this.http.get<Formation>(`${this.apiUrl}/${id}`);
  }

  getFormationByName(name:string):Observable<Formation>{
    return this.http.get<Formation>(`${this.apiUrl}/${name}`);
  }


}
