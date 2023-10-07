import { Component, OnInit } from '@angular/core';
import * as Highcharts from 'highcharts';
import { Category } from './models/category';
import { Product } from './models/product';
import { Brand } from './models/brand';
import { Sale } from './models/sale';
import { ApiService } from './api.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  constructor(private apiService: ApiService) { }

  Highcharts: typeof Highcharts = Highcharts;
  categories: Category[] = [];
  products: Product[] = [];
  brands: Brand[] = [];
  sales: Sale[] = [];
  _selectedCategory: number = 0;
  _selectedProduct: number = 0;
  _selectedBrand: number = 0;
  options!: Highcharts.Options;

  get selectedCategory(): number { return this._selectedCategory; }
  set selectedCategory(value: number) {
    this._selectedCategory = value;
    this.products = [];
    this.selectedProduct = 0;
    this.brands = [];
    this.selectedBrand = 0;

    if (this._selectedCategory !== 0)
      this.getProducts();
  }

  get selectedProduct(): number { return this._selectedProduct; }
  set selectedProduct(value: number) {
    this._selectedProduct = value;
    this.brands = [];
    this.selectedBrand = 0;

    if (this.selectedProduct !== 0)
      this.getBrands();
  }

  get selectedBrand(): number { return this._selectedBrand; }
  set selectedBrand(value: number) {
    this._selectedBrand = value;

    if (this.selectedBrand !== 0)
      this.getSales();
  }

  ngOnInit(): void {
    this.apiService.getCategories().subscribe(cat => {
      this.categories = cat;
      this.selectedCategory = this.categories[0].id;
    });
  }

  setChartOptions(): void {
    this.options = {
      title: {
        text: 'Sales By Month for:'
      },
      series: [{
        type: 'column',
        name: "Sales",
        data: this.sales.filter(sale => sale.id_brand === this.selectedBrand).map(d => ({ y: d.value, x: d.month - 1 }))
      }],
      xAxis: {
        categories: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'],
        labels: {
          step: 1
        }
      },
    };
  }

  handleUpdateCategory(event: Event) {
    this.selectedCategory = parseInt((event.target as HTMLSelectElement).value);
  }

  handleUpdateProduct(event: Event) {
    this.selectedProduct = parseInt((event.target as HTMLSelectElement).value);
  }

  handleUpdateBrand(event: Event) {
    this.selectedBrand = parseInt((event.target as HTMLSelectElement).value);
  }

  getProducts() {
    this.apiService.getProducts(this.selectedCategory).subscribe(pro => {
      this.products = pro;
      this.selectedProduct = this.products[0].id;
    })
  }

  getBrands() {
    this.apiService.getBrands(this.selectedProduct).subscribe(bra => {
      this.brands = bra;
      this.selectedBrand = this.brands[0].id;
    })
  }

  getSales() {
    this.apiService.getSales(this.selectedBrand).subscribe(sal => {
      this.sales = sal;
      this.setChartOptions();
    })
  }
}