import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private apiUrl = 'https://localhost:7291/api/Product'; 

  constructor(private https: HttpClient) { }

  getProducts(): Observable<any> {
    return this.https.get(`${this.apiUrl}/GetProducts`);
  }

  getProductAttributes(id: number): Observable<any> {
    return this.https.get(`${this.apiUrl}/GetProductAttributes/${id}`);
  }
}
