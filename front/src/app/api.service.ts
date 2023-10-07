import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Category } from './models/category';
import { Product } from './models/product';
import { Brand } from './models/brand';
import { Sale } from './models/sale';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  private baseURL = 'https://localhost:62778'; // Substitua por sua URL base da API

  constructor(private http: HttpClient) { }

  getBrands(id_product: number): Observable<Brand[]> {
    return this.http.get<Brand[]>(`${this.baseURL}/api/v1/Brand?id_product=${id_product}`);
  }

  getCategories(): Observable<Category[]> {
    return this.http.get<Category[]>(`${this.baseURL}/api/v1/Category`);
  }

  getProducts(id_category: number): Observable<Product[]> {
    return this.http.get<Product[]>(`${this.baseURL}/api/v1/Product?id_category=${id_category}`);
  }

  getSales(id_brand: number): Observable<Sale[]> {
    return this.http.get<Sale[]>(`${this.baseURL}/api/v1/Sale?id_brand=${id_brand}`);
  }
}