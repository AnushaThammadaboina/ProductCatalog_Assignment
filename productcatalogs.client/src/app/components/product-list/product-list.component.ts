import { Component, OnInit } from '@angular/core';
import { ProductService } from '../../services/product.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {
  products: any[] = [];
  attributes: any[] = [];
  selectedProduct: any = null;
  message = '';

  constructor(private productService: ProductService) { }

  ngOnInit(): void {
    this.loadProducts();
  }

  loadProducts() {
    this.productService.getProducts().subscribe({
      next: (data) => {
        this.products = data;
        this.message = data.length ? '' : 'No products available';
      },
      error: () => (this.message = 'Failed to load products')
    });
  }

  showAttributes(id: number) {
    this.productService.getProductAttributes(id).subscribe({
      next: (data) => {
        this.attributes = data;
        this.selectedProduct = id;
        this.message = data.length ? '' : 'No attributes found for this product.';
      },
      error: () => {
        this.attributes = [];
        this.message = 'No attributes found for this product.';
      }
    });
  }
}
