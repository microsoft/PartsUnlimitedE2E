terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "3.22.0"
    }
  }
  backend "azurerm" {
    resource_group_name  = "sa-tf-backends"
    storage_account_name = "azb23tfremotebackends1"
    container_name       = "tfremotebackends1"
    key                  = "dev.terraform.tfstate"
  }
}

provider "azurerm" {
  # Configuration options
  features {

  }
}
module "create-rg-01" {
  source       = "./modules/rg"
  rg_name      = var.rg_01_name
  rg_location  = var.rg_01_location
  tag_env_name = var.tag_env_name
}

resource "azurerm_virtual_network" "vnet-01" {
  name                = var.vnet_01_name
  address_space       = var.vnet_01_address_space
  location            = var.rg_01_location
  resource_group_name = var.rg_01_name
  depends_on = [
    module.create-rg-01
  ]
}

resource "azurerm_subnet" "subnet-01" {
  name                 = var.subnet_01_name
  resource_group_name  = var.rg_01_name
  virtual_network_name = var.vnet_01_name
  address_prefixes     = var.subnet_01_address_perfix
depends_on = [
    module.create-rg-01
  ]
}




