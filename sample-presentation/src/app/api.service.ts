import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http:HttpClient) { }

  getApiMessage()
  {
    let url = 'https://localhost:44302/HelloWorld';

    return this.http.get(url,{responseType: 'text'});
    
  }

}
