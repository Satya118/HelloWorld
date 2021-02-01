import { Component, OnInit } from '@angular/core';
import { ApiService } from './api.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  constructor(private apiService:ApiService){

  }
  title = 'sample-presentation';
  message:string;
  
  

  ngOnInit()
  {

    this.apiService.getApiMessage().subscribe(data => {      
      this.message = data;      
    });
  }
}
